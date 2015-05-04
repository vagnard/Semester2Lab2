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
            NewOrganisation.Country = new Country();
            InitializeComponent();
        }

        public AddOrganisation(BindingList<string> countryNames)
        {
            NewOrganisation = new Organisation();
            NewOrganisation.Country = new Country();
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
                    NewOrganisation.Country.country_name = orgCountry_cmbx.Text.Trim();
                    NewOrganisation.org_name= orgName_txbx.Text.Trim();
                    NewOrganisation.org_website = orgWebsity_txbx.Text.Trim();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
