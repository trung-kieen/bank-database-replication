using System;
using System.Collections.Generic;
using System.Data;

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
            _rows = rowView.Row.ItemArray.Clone() as object[];
            _rowView = rowView;
            originPosition = _bds.Position;
        }
        public void Execute()
        {
            bool bdsNotContainNewRow = _bds.IndexOf(_rowView) == -1;
            if(bdsNotContainNewRow)
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
            this.Execute();
        }

    }

    class DeleteCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _rows;
        private int originPosition;
        private String _sortColumn;
        private DeleteCommand(BankReplication.utils.BindingSourceExtends bds, object[] rows, String sortColumn)
        {
            _bds = bds;
            _rows = rows;
            originPosition = _bds.Position;
            _sortColumn = sortColumn;
        }
        public DeleteCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView, String sortColumn = null)
        {
            _rowView = rowView;
            _bds = bds;
            originPosition = _bds.Position;
            _sortColumn = sortColumn;
            if (_sortColumn != null) _bds.Sort = _sortColumn;
            originPosition = _bds.Position;
        }
        public void Execute()
        {
            if (_bds.Count > 0)
            {
                _rows = _rowView.Row.ItemArray.Clone() as object[];
                _bds.Focus(_rowView);
                _bds.Remove((DataRowView)_rowView);

            }
        }
        public void Undo()
        {
            _bds.ResetCurrentItem();
            if (_sortColumn != null) _bds.Sort = _sortColumn;
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
            command.Execute();
            redoStack.Clear();
            undoStack.Push(command);
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                ICommand cmd = undoStack.Pop();
                cmd.Undo();
                redoStack.Push(cmd);
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                ICommand cmd = redoStack.Pop();
                cmd.Redo();
                undoStack.Push(cmd);
            }
        }


    }




}
