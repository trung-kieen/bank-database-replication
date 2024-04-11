using DevExpress.Utils.DirectXPaint;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
        public AddCommand(BankReplication.utils.BindingSourceExtends bds, object[] rows)
        {
            _bds = bds;
            _rows = rows;
            originPosition = _bds.Position;
        }
        public AddCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView)
        {
            _bds = bds;
            _rows = ModelMapper.RowViewToRowList(rowView);
            _rowView = rowView;
            originPosition = _bds.Position;
        }
        public void Execute()
        {
            bool bdsNotContainNewRow = _bds.IndexOf(_rowView) == -1;
            if (bdsNotContainNewRow)
            {
                _rowView = (DataRowView)_bds.AddNew();
                _rowView.Row.ItemArray = _rows;
            }
            else
            {
            }
            _bds.Focus(_rowView);


        }
        public void Undo()
        {
            _bds.Focus(_rowView);
            _bds.Remove(_rowView);

            //            if (originPosition > 0) _bds.Position = originPosition - 1;
            //            _bds.Position = originPosition;

        }
        public void Redo()
        {
//            _bds.Insert(originPosition, _rowView);
            _bds.Insert(originPosition, _rows);
  //        this.Execute();
        }

    }

    class DeleteCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _rows;
        private int originPosition;
        public DeleteCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView)
        {
            _rowView = rowView;
            _bds = bds;
            originPosition = _bds.Position;
        }
        public void Execute()
        {
            if (_bds.Count > 0)
            {
                _rows = ModelMapper.RowViewToRowList(_rowView);
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
            _bds.Focus(_rowView);
        }
        public void Redo()
        {
            // Same with execute but not change postion
            int originPosition = _bds.Position;
            this.Execute();
            _bds.Position = originPosition;
        }

    }
class EditCommand: ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _before;
        private object[] _after;
        public EditCommand(BankReplication.utils.BindingSourceExtends bds)
        {
            _bds = bds;
            _before = ModelMapper.RowViewToRowList((DataRowView)_bds.Current);
            _bds.EndEdit();
            _after= ModelMapper.RowViewToRowList((DataRowView)_bds.Current);
            _rowView =(DataRowView) _bds.Current;
        }
        public void Execute()
        {
            _bds.Update(_bds.IndexOf(_before), _after);
        }
        public void Undo()
        {
            int position = _bds.IndexOf(_after);
            _bds.Update(position, _before);

            _bds.Position = position;
        }
        public void Redo()
        {
            int position = _bds.IndexOf(_before);
            _bds.Update(position, _after);

            _bds.Position = position;
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
                MessageBox.Show(ex.ToString(), "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return  rowView.Row.ItemArray.Clone() as object[];
        }

    }



}
