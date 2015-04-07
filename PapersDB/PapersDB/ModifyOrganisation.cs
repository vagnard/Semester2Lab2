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
    public partial class ModifyOrganisation : Form
    { 
        public Organisation modifyOrg;

        
        public ModifyOrganisation()
        {
            modifyOrg = new Organisation();
            InitializeComponent();
        }

        public ModifyOrganisation(List<string> countryNames)
        {
            modifyOrg = new Organisation();
            InitializeComponent();
            orgCountry_cmbx.DataSource = countryNames;
        }

        private void modifyOrg_btn_Click(object sender, EventArgs e)
        {
            if (orgID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                   try
                   {
                       modifyOrg.ID = Convert.ToInt32(orgID_txbx.Text.Trim());
                   }
                   catch (FormatException)
                   {
                       MessageBox.Show("Input string is not a sequence of digits.");
                   }
                   modifyOrg.Name = orgName_txbx.Text.Trim();
                   modifyOrg.Website = orgWebsity_txbx.Text.Trim();
                   modifyOrg.Country = orgCountry_cmbx.Text.Trim();

                   DialogResult = DialogResult.OK;
            }
        }
    }
}
