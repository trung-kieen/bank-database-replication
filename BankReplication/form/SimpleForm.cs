﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BankReplication.form
{
    public partial class SimpleForm : DevExpress.XtraEditors.XtraForm
    {
        public virtual void HandleAdd() { }
        public virtual void HandleDelete() { }
        public SimpleForm()
        {
            InitializeComponent();
        }
        public void BaseComponent()
        {
        }
    }
}