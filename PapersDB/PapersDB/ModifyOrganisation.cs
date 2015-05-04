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

        public ModifyOrganisation(int ID, BindingList<string> countryNames)
        {
            modifyOrg = new Organisation();
            modifyOrg.org_id = ID;
            modifyOrg.Country = new Country();
            InitializeComponent();
            orgCountry_cmbx.DataSource = countryNames;
        }

        private void modifyOrg_btn_Click(object sender, EventArgs e)
        {
            
            modifyOrg.org_name = orgName_txbx.Text.Trim();
            modifyOrg.org_website = orgWebsity_txbx.Text.Trim();
            modifyOrg.Country.country_name = orgCountry_cmbx.Text.Trim();

            DialogResult = DialogResult.OK;
            
        }
    }
}
