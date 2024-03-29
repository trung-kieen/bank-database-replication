using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReplication.utils
{
    public class SimpleForm: DevExpress.XtraEditors.XtraForm
    {
        public virtual void HandleAdd() { } 
        public virtual void HandleDelete() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SimpleForm
            // 
            this.ClientSize = new System.Drawing.Size(1918, 1033);
            this.Name = "SimpleForm";
            this.ResumeLayout(false);

            // Make user unable to close tab
            this.ControlBox = false;

        }
    }
   
}
