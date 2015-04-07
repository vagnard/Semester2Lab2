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
    public partial class ModifySubject : Form
    {
        public Subject modifySubject;
        public ModifySubject()
        {
            modifySubject = new Subject();
            InitializeComponent();
        }
       
        

        private void modSubject_btn_Click(object sender, EventArgs e)
        {
            if (subjectID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                if (subjectName_txbx.Text.Trim() == "")
                    MessageBox.Show("Name is empty");
                else
                {
                    try
                    {
                        modifySubject.ID = Convert.ToInt32(subjectID_txbx.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Input string is not a sequence of digits.");
                    }
                    modifySubject.Name = subjectName_txbx.Text.Trim();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
