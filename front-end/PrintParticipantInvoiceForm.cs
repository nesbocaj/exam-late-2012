﻿using System;
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
    public partial class PrintParticipantInvoiceForm : BaseAddForm
    {
        public PrintParticipantInvoiceForm()
        {
            InitializeComponent();
            okButton.Click += Print;
        }

        public void Print(object sender, EventArgs e)
        {

        }
        private void PrintParticipantInvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
