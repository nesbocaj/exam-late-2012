using System;
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

        private back_end.Controller SearchControl;

        public BaseTabControl()
        {
            InitializeComponent();
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchControl.Search(SearchBox.Text.ToString());
        }
    }
}
