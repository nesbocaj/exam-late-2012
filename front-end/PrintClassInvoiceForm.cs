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
    public partial class PrintClassInvoiceForm : BaseAddForm
    {
        public PrintClassInvoiceForm()
        {
            InitializeComponent();
            okButton.Click += Print;
        }

        public void Print (object sender, EventArgs e)
        {


            this.Close();
        }
    }
}
