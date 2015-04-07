using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapersDB
{
    public partial class DeleteSubject : Form
    {
        public int ID;
        public DeleteSubject()
        {
            ID = -1;
            InitializeComponent();
        }

        private void delSubject_btn_Click(object sender, EventArgs e)
        {
            if (subjectID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                try
                {
                    ID = Convert.ToInt32(subjectID_txbx.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Input string is not a sequence of digits.");
                }
                DialogResult = DialogResult.OK;
            }
        }
        
    }
}
