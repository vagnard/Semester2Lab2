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
    public partial class DeleteCountry : Form
    {
        public int ID;
        public DeleteCountry()
        {
            ID = -1;
            InitializeComponent();
        }

        private void delCountry_btn_Click(object sender, EventArgs e)
        {
            if (countryID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                try
                {
                    ID = Convert.ToInt32(countryID_txbx.Text.Trim());
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
