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
    public partial class AddClassForm : BaseAddForm
    {
        public AddClassForm()
        {
            InitializeComponent();
            this.printButton.Visible = true;
            this.printButton.Click += Print_Click;
        }

        public void Print_Click(object sender, EventArgs e)
        {
            PrintClassInvoiceForm PCIF = new PrintClassInvoiceForm();

            PCIF.ShowForm();
        }
    }
}
