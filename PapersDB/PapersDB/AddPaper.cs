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
    public partial class AddPaper : Form
    {
        public Paper newPaper;
        public AddPaper()
        {
            newPaper = new Paper();
            InitializeComponent();
        }
        public AddPaper(BindingList<string> subjNames, BindingList<string> langNames)
        {
            newPaper = new Paper();
            newPaper.Language = new Language();
            newPaper.Subject = new Subject();
            InitializeComponent();
            subject_cmbx.DataSource = subjNames;
            language_cmbx.DataSource = langNames;
        }
        private void addPaper_btn_Click(object sender, EventArgs e)
        {
            if (orgTitle_txbx.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else
            {
                if (subject_cmbx.Text.Trim() == "")
                    MessageBox.Show("Subject is empty");
                else
                {
                    if (language_cmbx.Text.Trim() == "")
                        MessageBox.Show("Language is empty");
                    else
                    {
                        newPaper.p_title = orgTitle_txbx.Text.Trim();
                        newPaper.Language.language_name = language_cmbx.Text.Trim();
                        newPaper.Subject.subj_name = subject_cmbx.Text.Trim();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
