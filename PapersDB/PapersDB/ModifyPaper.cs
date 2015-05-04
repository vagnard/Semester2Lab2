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

        public ModifyPaper(int ID, BindingList<string> subjectNames, BindingList<string> languageNames)
        {
            modifyPaper = new Paper();
            modifyPaper.p_id = ID;
            modifyPaper.Language = new Language();
            modifyPaper.Subject = new Subject();
            InitializeComponent();
            paperLanguage_cmbx.DataSource = languageNames;
            paperSubject_cmbx.DataSource = subjectNames;
        }

        private void modifyPaper_btn_Click(object sender, EventArgs e)
        {
          
                   modifyPaper.p_title = paperName_txbx.Text.Trim();
                   modifyPaper.Language.language_name = paperLanguage_cmbx.Text.Trim();
                   modifyPaper.Subject.subj_name = paperSubject_cmbx.Text.Trim();

                   DialogResult = DialogResult.OK;
        }
        

       
    }
}
