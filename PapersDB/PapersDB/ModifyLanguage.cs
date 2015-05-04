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
            
                if (languageName_txbx.Text.Trim() == "")
                    MessageBox.Show("Name is empty");
                else
                {
                   
                    modifyLanguage.language_name = languageName_txbx.Text.Trim();
                    DialogResult = DialogResult.OK;
                }
        }
    }
}
