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
    public partial class AddScientist : Form
    {
        public Scientist NewScientist;

        public AddScientist()
        {
            NewScientist = new Scientist();
            InitializeComponent();
        }

        public AddScientist(BindingList<string> orgNames)
        {
            NewScientist = new Scientist();
            NewScientist.Organisation = new Organisation();
            InitializeComponent();
            sciOrg_cmbx.DataSource = orgNames;
        }

        private void addSci_btn_Click(object sender, EventArgs e)
        {
            if (sciName_txbx.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else
            {
                if (sciOrg_cmbx.Text.Trim() == "")
                    MessageBox.Show("Organisation is empty");
                else
                {
                    float hindex = 0;
                    try
                    {
                        hindex = (float)Convert.ToDouble(sciHind_txbx.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        if (sciHind_txbx.Text.Trim() != "")
                        {
                            MessageBox.Show("Input string for hindex is not a sequence of digits.");
                            return;
                        }
                    }
                    NewScientist.s_name = sciName_txbx.Text.Trim();
                    NewScientist.Organisation.org_name = sciOrg_cmbx.Text.Trim();
                    NewScientist.s_email = sciEmail_txbx.Text.Trim();
                    NewScientist.s_hindex = hindex;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
