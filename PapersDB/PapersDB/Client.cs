using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessToPapers;
using Common;

namespace PapersDB
{
    public partial class Client : Form
    {
        AccessToPapers.AccessToPapers accessToPapers;

        public Client()
        {
            InitializeComponent();
            LogIn logIn = new LogIn();
            if (logIn.ShowDialog() == DialogResult.OK)
            {
                accessToPapers = new AccessToPapers.AccessToPapers(logIn.DBType, logIn.ConnectionParameters);

                RefreshOrg_Click(null, null);
                CountriesRefresh_btn_Click(null, null);
            }
        }

        private void RefreshOrg_Click(object sender, EventArgs e)
        {
            List<Organisation> allOrgs = new List<Organisation>();
            allOrgs = accessToPapers.GetAllOrganisations();
            org_dgv.DataSource = allOrgs;
        }

        private void addNewOrg_Click(object sender, EventArgs e)
        {
            Organisation organisation = new Organisation();
            NewOrg newOrg = new NewOrg();
            if (newOrg.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.addOrganisation(organisation);
            }
        }


        // Country

        private void addCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCountry newCountry = new AddCountry();
            if ( newCountry.ShowDialog() == DialogResult.OK ) 
            {

                if (!accessToPapers.addCountry(newCountry.NewCountry))
                    MessageBox.Show("Such country already exists");
                CountriesRefresh_btn_Click(null, null);
            }
            
        }

        private void CountriesRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Country> allCountries = new List<Country>();
            allCountries = accessToPapers.GetAllCountries();
            countries_dgv.DataSource = allCountries;
            countries_dgv.Columns["ID"].ReadOnly = true;
            OrgCountry_cmbx.Items.Add(allCountries[0].Name);
        }

        

        private void deleteCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCountry deleteCountry = new DeleteCountry();
            if (deleteCountry.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteCountry(deleteCountry.NewCountry.ID))
                    MessageBox.Show("Such country does not exist");
                CountriesRefresh_btn_Click(null, null);
            }
        }

        private void countries_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (countries_dgv.CurrentCell.Value == null)
            {
                accessToPapers.deleteCountry((int)countries_dgv.CurrentRow.Cells["ID"].Value);
                CountriesRefresh_btn_Click(null, null);
            }
            else
                accessToPapers.updateCountry((int)countries_dgv.CurrentRow.Cells["ID"].Value, countries_dgv.CurrentCell.Value);
        }

      

    }
}
