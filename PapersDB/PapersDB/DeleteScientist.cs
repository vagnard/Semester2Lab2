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
    public partial class DeleteScientist : Form
    {
        public int ID;
        public DeleteScientist()
        {
            ID = -1;
            InitializeComponent();
        }

        private void delSci_btn_Click(object sender, EventArgs e)
        {
            if (sciID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                try
                {
                    ID = Convert.ToInt32(sciID_txbx.Text.Trim());
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
