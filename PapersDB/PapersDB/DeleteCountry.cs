using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace PapersDB
{
    public partial class DeleteCountry : Form
    {
        public Country NewCountry;
        public DeleteCountry()
        {
            NewCountry = new Country();
            InitializeComponent();
        }

        private void delCountry_btn_Click(object sender, EventArgs e)
        {
            if (countryName_txbx.Text.Trim() == null)
                MessageBox.Show("Name is empty");
            else
            {
                NewCountry.Name = countryName_txbx.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
