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
    public partial class LogIn : Form
    {
        public string ConnectionParameters { get; private set; }
        public SourceType DBType { get; private set; }
        public LogIn()
        {
            InitializeComponent();

            ConnectionString_txbx.Text = "Data Source=;Initial Catalog=;uid=;pwd=";
        }

        private void XML_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            XML_gpbox.Enabled = XML_rdbtn.Checked;
            SQL_gpbox.Enabled = !XML_rdbtn.Checked;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectionParam_txbx_TextChanged(object sender, EventArgs e)
        {
            Login_txbx.Enabled = !UseWinAuth_chbx.Checked;
            Password_txbx.Enabled = !UseWinAuth_chbx.Checked;
            if (UseWinAuth_chbx.Checked)
            {
                
                ConnectionString_txbx.Text = String.Format(
                    "Data Source={0};Initial Catalog={1};Integrated Security=True",
                    DataSource_txbx.Text.Trim(), InitCatalog_txbx.Text.Trim()
                    );
            }
            else
            {
                ConnectionString_txbx.Text = String.Format(
                    "Data Source={0};Initial Catalog={1};uid={2};pwd={3}",
                    DataSource_txbx.Text.Trim(), InitCatalog_txbx.Text.Trim(),
                    Login_txbx.Text.Trim(), Password_txbx.Text.Trim()
                    );
            }
        }

        private void ChooseXMLFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenXML = new OpenFileDialog();
            OpenXML.FileName = "";
            OpenXML.Filter = "File XML (*.xml)|*.xml|All files (*.*)|*.*";

            if (OpenXML.ShowDialog() == DialogResult.OK)
                XMLFile_txbx.Text = OpenXML.FileName;
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if (XML_rdbtn.Checked)
            {
                ConnectionParameters = XMLFile_txbx.Text;
                DBType = SourceType.XML;
            }
            else
            {
                if (DataSource_txbx.Text == "" || InitCatalog_txbx.Text == "")
                {
                    MessageBox.Show("No location server or target data source");
                    return;
                }
                if ( !UseWinAuth_chbx.Checked &&
                    (Login_txbx.Text == "" || Password_txbx.Text == "") )
                {
                    MessageBox.Show("No login and password");
                    return;
                }
                ConnectionParameters = ConnectionString_txbx.Text;
                DBType = SourceType.SQL;
            }
            DialogResult = DialogResult.OK;

        }

       

    }
}
