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
    public partial class HourReportForm : BaseAddForm
    {
        public HourReportForm()
        {
            InitializeComponent();
            okButton.Click += ReportedHour;
        }

        public void ReportedHour (object sender, EventArgs e)
        {
            MessageBox.Show("Du har nu indberettet dine arbejdstimer.");
            this.Close();
        }

        private void HourReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
