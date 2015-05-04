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
        public ModifyCountry(int ID)
        {
            modifyCountry = new Country();
            modifyCountry.country_id = ID;
            InitializeComponent();
        }

        private void modCountry_btn_Click(object sender, EventArgs e)
        {
         if (countryName_txbx.Text.Trim() == "")
              MessageBox.Show("Name is empty");
         else
         {
             modifyCountry.country_name = countryName_txbx.Text.Trim();
             DialogResult = DialogResult.OK;
         }
        }
    }
}
