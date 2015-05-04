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
    public partial class ModifyScientist : Form
    {
        public Scientist modifySci;

        public ModifyScientist()
        {
            modifySci = new Scientist();
            InitializeComponent();
        }

        public ModifyScientist(int ID, BindingList<string> orgNames)
        {
            modifySci = new Scientist();
            modifySci.s_id = ID;
            modifySci.Organisation = new Organisation();
            InitializeComponent();
            sciOrg_cmbx.DataSource = orgNames;
        }

        private void modifySci_btn_Click(object sender, EventArgs e)
        {
           
                modifySci.s_name = sciName_txbx.Text.Trim();
                modifySci.Organisation.org_name = sciOrg_cmbx.Text.Trim();
                modifySci.s_email = sciEmail_txbx.Text.Trim();
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
                modifySci.s_hindex= hindex;

                DialogResult = DialogResult.OK;
            }
    }
}
