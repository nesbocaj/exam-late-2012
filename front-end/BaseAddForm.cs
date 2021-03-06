﻿using back_end;
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
    public partial class BaseAddForm : Form
    {

        protected Controller controller;

        public BaseAddForm()
        {
            InitializeComponent();
            this.cancelButton.Click += Cancel_Click;
        }

        public void ShowForm(int? id = null)
        {
            if (id != null)
            {
                okButton.Click += SaveExisting;
                this.Text = this.Text.Replace("Opret", "Rediger");
            }
            else
                okButton.Click += SaveNew;

            this.ShowDialog();
        }

        protected virtual void SaveExisting(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void SaveNew(object sender, EventArgs e)
        {
            //InputControl.
            this.Close();
        }

        public void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void BaseAddForm_Shown(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }
    }
}
