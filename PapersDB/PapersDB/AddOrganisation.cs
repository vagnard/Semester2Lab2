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
    public partial class AddOrganisation : Form
    {
        public Organisation NewOrganisation;
        public AddOrganisation()
        {
            NewOrganisation = new Organisation();
            InitializeComponent();
        }

        public AddOrganisation(List<string> countryNames)
        {
            NewOrganisation = new Organisation();
            InitializeComponent();
            orgCountry_cmbx.DataSource = countryNames;
        }

        private void addOrg_btn_Click(object sender, EventArgs e)
        {
            if (orgName_txbx.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else
            {
                if (orgCountry_cmbx.Text.Trim() == "")
                    MessageBox.Show("Country is empty");
                else
                {
                    NewOrganisation.Country = orgCountry_cmbx.Text.Trim();
                    NewOrganisation.Name = orgName_txbx.Text.Trim();
                    NewOrganisation.Website = orgWebsity_txbx.Text.Trim();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
