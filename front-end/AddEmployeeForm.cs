using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_late_2012
{
    public partial class AddEmployeeForm : BaseAddForm
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            /*
            OKButton.Click += OK_Click;
            CancelButton.Click += Cancel_Click;
            */
        }

        protected virtual void SaveExisting(object sender, EventArgs e)
        {

        }

        protected virtual void SaveNew(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
