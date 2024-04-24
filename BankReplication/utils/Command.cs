using DevExpress.Utils.DirectXPaint;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BankReplication;
using BankReplication.utils;

namespace BankReplication.utils
{

    // The Command interface declares a method for executing a command and feature undo and redo.
    public interface ICommand
    {
        void Execute();
        void Undo();

        void Redo();
    }

    class AddCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _rows;
        private int originPosition;
        private Action _afterAction;
        public AddCommand(BankReplication.utils.BindingSourceExtends bds, object[] rows, Action afterAction)
        {
            _bds = bds;
            _rows = rows;
            originPosition = _bds.Position;
        }
        public AddCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView, Action afterAction)
        {
            _bds = bds;
            _rows = ModelMapper.RowViewToRowList(rowView);
            _rowView = rowView;
            originPosition = _bds.Position;
            _afterAction = afterAction;
        }
        public void Execute()
        {
            bool bdsNotContainNewRow = _bds.IndexOf(_rowView) == -1;
            if (bdsNotContainNewRow)
            {
                _rowView = (DataRowView)_bds.AddNew();
                _rowView.Row.ItemArray = _rows;
                if (_afterAction != null)
                    _afterAction();
                _bds.Focus(_rowView);

            }
            else
            {
            }
            _bds.Focus(_rowView);

        }
        public void Undo()
        {
            if (_afterAction != null)
                _afterAction();
            _bds.Focus(_rowView);
            _bds.Remove(_rowView);

        }
        public void Redo()
        {
            this.Execute();
        }

    }

    class DeleteCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _rows;
        private int originPosition;
        private Action _afterAction;
        public DeleteCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView, Action afterAction)
        {
            _rowView = rowView;
            _bds = bds;
            originPosition = _bds.Position;
            _afterAction = afterAction;
        }
        public void Execute()
        {
            if (_bds.Count > 0)
            {
                _rows = ModelMapper.RowViewToRowList(_rowView);
                if (_afterAction != null)
                    _afterAction();
                _bds.Focus(_rowView);
                _bds.Remove((DataRowView)_rowView);

            }
        }
        public void Undo()
        {
            _bds.ResetCurrentItem();
            DataRowView newRow = (DataRowView)_bds.AddNew();

            newRow.Row.ItemArray = _rows;
            _rowView = newRow;
            if (_afterAction != null)
                _afterAction();
            _bds.Focus(_rowView);
        }
        public void Redo()
        {
            if (_afterAction != null)
                _afterAction();
            // Same with execute but not change postion
            int originPosition = _bds.Position;
            this.Execute();
            _bds.Position = originPosition;
        }

    }
    class EditCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _before;
        private object[] _after;
        private Action _afterAction;
        public EditCommand(BankReplication.utils.BindingSourceExtends bds, Action afterAction)
        {
            _bds = bds;
            _before = ModelMapper.RowViewToRowList((DataRowView)_bds.Current);
            _bds.EndEdit();
            _after = ModelMapper.RowViewToRowList((DataRowView)_bds.Current);
            _rowView = (DataRowView)_bds.Current;
            _afterAction = afterAction;
        }
        public void Execute()
        {
            _bds.Update(_bds.IndexOf(_before), _after);
        }
        public void Undo()
        {
            if (_afterAction != null)
                _afterAction();
            int position = _bds.IndexOf(_after);
            _bds.Update(position, _before);

            _bds.Position = position;
        }
        public void Redo()
        {
            if (_afterAction != null)
                _afterAction();
            int position = _bds.IndexOf(_before);
            _bds.Update(position, _after);

            _bds.Position = position;
        }

    }
    class ChuyenCNCommand : ICommand
    {
        //        private BindingSourceExtends _bds;
        private String _connString;
        private String _maNVCu;
        private String _maNVMoi;
        private Action _afterAction;
        public ChuyenCNCommand(BindingSourceExtends bds, String connString, String maNVMoi)
        {
            //            _bds = bds;
            _connString = connString;
            _maNVCu = ((DataRowView)bds[bds.Position]).Row["MANV"].ToString();
            _maNVMoi = maNVMoi;

        }
        public ChuyenCNCommand(String connString, String maNVCu, String maNVMoi)
        {
            _connString = connString;
            _maNVMoi = maNVMoi;
            _maNVCu = maNVCu;
        }
        public ChuyenCNCommand(String connString, String maNVCu, String maNVMoi, Action afterAction)
        {
            _connString = connString;
            _maNVMoi = maNVMoi;
            _maNVCu = maNVCu;
            _afterAction = afterAction;
        }
        public void Execute()
        {
            Program.connstr = _connString;
            if (Program.KetNoi(Database.Connection.NotShowError) == Database.Connection.Fail)
            {
                Msg.Error("Không thể kết nối tới máy chủ");
                return;
            }
            try
            {

                String SPName = "SP_ChuyenNhanVien";
                String cmd = "EXEC " + SPName + " '" + _maNVCu + "', '" + _maNVMoi + "'";

                Program.ExecSqlNonQuery(cmd);
                if (_afterAction != null)
                    _afterAction();

                Msg.Info("Nhân viên đã được chuyển qua chi nhánh mới với mã nhân viên là " + _maNVMoi);

            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi khi chuyển nhân viên\n" + ex.Message, "Thao tác không thành công");

            }

        }
        public void Undo()
        {
            Program.connstr = _connString;
            if (Program.KetNoi(Database.Connection.NotShowError) == Database.Connection.Fail)
            {
                Msg.Error("Không thể kết nối tới máy chủ");
                return;
            }
            try
            {
                String SPName = "SP_ChuyenNhanVien_Undo";
                String cmd = "EXEC " + SPName + " '" + _maNVCu + "', '" + _maNVMoi + "'";
                Program.ExecSqlNonQuery(cmd);
                if (_afterAction != null)
                    _afterAction();
                Msg.Info("Nhân viên đã được chuyển quay lại chi nhánh cũ");
            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi khi chuyển nhân viên\n" + ex.Message, "Thao tác không thành công");

            }

        }

        public void Redo()
        {
            this.Execute();

        }

    }

    // The Invoker is associated with one or several commands. It sends a
    // request to the command.
    public class Invoker
    {
        private Stack<ICommand> undoStack;
        private Stack<ICommand> redoStack;

        public Invoker()
        {
            undoStack = new Stack<ICommand>();
            redoStack = new Stack<ICommand>();
        }

        public void Execute(ICommand command)
        {
            try
            {
                command.Execute();
                redoStack.Clear();
                undoStack.Push(command);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, "Thao tác không thành công");
            }
        }

        public void Undo()
        {

            try
            {
                if (undoStack.Count > 0)
                {
                    ICommand cmd = undoStack.Pop();
                    cmd.Undo();
                    redoStack.Push(cmd);
                }
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, "Thao tác không thành công");
            }
        }

        public void Redo()
        {
            try
            {
                if (redoStack.Count > 0)
                {
                    ICommand cmd = redoStack.Pop();
                    cmd.Redo();
                    undoStack.Push(cmd);
                }
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, "Thao tác không thành công");
            }
        }
        public Boolean Redoable()
        {
            return redoStack.Count > 0;
        }

        public Boolean Undoable()
        {
            return undoStack.Count > 0;
        }

    }


    public class ModelMapper
    {
        public static object[] RowViewToRowList(DataRowView rowView)
        {
            return rowView.Row.ItemArray.Clone() as object[];
        }

    }



}
