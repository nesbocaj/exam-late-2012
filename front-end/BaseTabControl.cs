﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_late_2012
{
    public partial class BaseTabControl : UserControl
    {
        public BaseTabControl()
        {
            InitializeComponent();
                    
        }

        public void SearchEmployee(object sender, EventArgs e)
        {

            Search
            string Indeks, Tekst;
            int tal;

            Indeks = "Test";
            Tekst = "Test";
            tal = 1;

            SearchBox.Text.ToString();
            listView.Items.Add(Indeks, Tekst, tal);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems != null)
            {
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
            else
            {
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
            }
        }
    }
}
