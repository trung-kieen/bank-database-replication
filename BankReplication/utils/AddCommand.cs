using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankReplication.form;

namespace BankReplication.utils
{
    class AddCommand : ICommand
    {
        public AddCommand(formNhanVien form)

        {
            form.HandleAdd();



        }
        public void Execute()
        {
                
        }
        public void Undo()
        {

        }
    }
}
