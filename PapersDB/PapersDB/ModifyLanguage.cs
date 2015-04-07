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
    public partial class ModifyLanguage : Form
    {
        public Language modifyLanguage;
        public ModifyLanguage()
        {
            modifyLanguage = new Language();
            InitializeComponent();
        }
        
        private void modLanguage_btn_Click(object sender, EventArgs e)
        {
            if (languageID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                if (languageName_txbx.Text.Trim() == "")
                    MessageBox.Show("Name is empty");
                else
                {
                    try
                    {
                        modifyLanguage.ID = Convert.ToInt32(languageID_txbx.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Input string is not a sequence of digits.");
                    }
                    modifyLanguage.Name = languageName_txbx.Text.Trim();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
