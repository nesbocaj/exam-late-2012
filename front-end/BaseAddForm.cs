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
    public partial class BaseAddForm : Form
    {
        public BaseAddForm()
        {
            InitializeComponent();
        }

        public void Show(int? id = null)
        {
            if (id != null)
            {
                OKButton.Click += SaveExisting;
                this.Text.Replace("Opret", "Rediger");
            }
            else
                OKButton.Click += SaveNew;
            this.Show();
        }

        protected virtual void SaveExisting(object sender, EventArgs e)
        {

        }

        protected virtual void SaveNew(object sender, EventArgs e)
        {

        }
    }
}
