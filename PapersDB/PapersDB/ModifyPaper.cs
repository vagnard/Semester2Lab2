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
    public partial class ModifyPaper : Form
    {
        public Paper modifyPaper;
        public ModifyPaper()
        {
            modifyPaper = new Paper();
            InitializeComponent();
        }

        public ModifyPaper(List<string> subjectNames, List<string> languageNames)
        {
            modifyPaper = new Paper();
            InitializeComponent();
            paperLanguage_cmbx.DataSource = languageNames;
            paperSubject_cmbx.DataSource = subjectNames;
        }

        private void modifyPaper_btn_Click(object sender, EventArgs e)
        {
            if (paperID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                   try
                   {
                       modifyPaper.ID = Convert.ToInt32(paperID_txbx.Text.Trim());
                   }
                   catch (FormatException)
                   {
                       MessageBox.Show("Input string is not a sequence of digits.");
                   }
                   modifyPaper.Title = paperName_txbx.Text.Trim();
                   modifyPaper.Language = paperLanguage_cmbx.Text.Trim();
                   modifyPaper.Subject = paperSubject_cmbx.Text.Trim();

                   DialogResult = DialogResult.OK;
            }
        }
        

       
    }
}
