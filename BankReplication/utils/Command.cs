using System.Collections.Generic;
using System.Data;

namespace BankReplication.utils
{

    // The Command interface declares a method for executing a command and feature undo and redo.
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    class AddCommand : ICommand
    {
        private System.Windows.Forms.BindingSource _bds;
        private DataRowView _rowView; 
        private object[] _rows;
        private int originPosition;
        public AddCommand(System.Windows.Forms.BindingSource bds, object[] rows)
        {
            _bds = bds;
            _rows = rows;
            originPosition = _bds.Position;
        }
        public AddCommand(System.Windows.Forms.BindingSource bds, DataRowView rowView)
        {
            _bds = bds;
            _rows = rowView.Row.ItemArray.Clone() as object[];
            originPosition = _bds.Position;
        }
        public void Execute()
        {
            _rowView= (DataRowView)_bds.AddNew();
            _rowView.Row.ItemArray = _rows;
        }
        public void Undo()
        {
            _bds.Remove(_rowView);
            if(originPosition > 0 ) _bds.Position = originPosition - 1 ;
            _bds.Position = originPosition;
            
        }

        // The Invoker is associated with one or several commands. It sends a
        // request to the command.
    }

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
                cmd.Execute();
                undoStack.Push(cmd);
            }
        }


    }




}
