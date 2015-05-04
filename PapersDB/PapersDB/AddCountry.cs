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
    public partial class AddCountry : Form
    {
        public Country country;
        public AddCountry()
        {
            country = new Country();
            InitializeComponent();
        }

        private void addCountry_btn_Click(object sender, EventArgs e)
        {
            if (countryName_txbx.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else
            {
                country.country_name = countryName_txbx.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
