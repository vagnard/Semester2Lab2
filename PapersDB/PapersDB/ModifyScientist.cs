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

        public ModifyScientist(List<string> orgNames)
        {
            modifySci = new Scientist();
            InitializeComponent();
            sciOrg_cmbx.DataSource = orgNames;
        }

        private void modifySci_btn_Click(object sender, EventArgs e)
        {
            if (sciID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                try
                {
                    modifySci.ID = Convert.ToInt32(sciID_txbx.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Input string is not a sequence of digits.");
                }
                modifySci.Name = sciName_txbx.Text.Trim();
                modifySci.organisationName = sciOrg_cmbx.Text.Trim();
                modifySci.Email = sciEmail_txbx.Text.Trim();
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
                modifySci.hindex = hindex;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
