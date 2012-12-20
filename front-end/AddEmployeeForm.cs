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
        }

        protected override void SaveExisting(object sender, EventArgs e)
        {

        }

        protected override void SaveNew(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
