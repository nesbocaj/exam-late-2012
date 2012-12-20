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
    public partial class AddParticipantForm : BaseAddForm
    {
        public AddParticipantForm()
        {
            InitializeComponent();
            this.printButton.Visible = true;
            this.printButton.Click += Print_Click;
        }

        public void Print_Click(object sender, EventArgs e)
        {
            PrintParticipantInvoiceForm PPIF = new PrintParticipantInvoiceForm();

            PPIF.ShowForm();
        }
    }
}
