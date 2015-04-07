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
    public partial class ModifyCountry : Form
    {
        public Country modifyCountry;
        public ModifyCountry()
        {
            modifyCountry = new Country();
            InitializeComponent();
        }

        private void modCountry_btn_Click(object sender, EventArgs e)
        {
            if (countryID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                if (countryName_txbx.Text.Trim() == "")
                    MessageBox.Show("Name is empty");
                else
                {
                    try
                    {
                        modifyCountry.ID = Convert.ToInt32(countryID_txbx.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Input string is not a sequence of digits.");
                    }
                    modifyCountry.Name = countryName_txbx.Text.Trim();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
