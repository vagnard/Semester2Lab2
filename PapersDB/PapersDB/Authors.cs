using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessToPapers;
using Common;

namespace PapersDB
{
    public partial class Authors : Form
    {
        AccessToPapers.AccessToPapers accessToPapers;
        int mPaperID;
        List<string> authorNames;

        public Authors()
        {
            InitializeComponent();
            AuthorRefresh_Click(null, null);
        }
        public Authors(AccessToPapers.AccessToPapers accessToPapers, int paperID, List<string> authorNames)
        {
            this.accessToPapers = accessToPapers;
            this.authorNames = authorNames;
            mPaperID = paperID;
            InitializeComponent();
            AuthorRefresh_Click(null, null);
        }
        private void AuthorRefresh_Click(object sender, EventArgs e)
        {
            List<Scientist> allAuthors = new List<Scientist>();
            allAuthors = accessToPapers.getAllAuthors(mPaperID, authorNameFilter_txbx.Text.Trim());
            Author_dgv.DataSource = allAuthors;
            Author_dgv.Columns["organisationName"].Visible = false;
            Author_dgv.Columns["Email"].Visible = false;
            Author_dgv.Columns["hindex"].Visible = false;
            Author_dgv.Columns["OrganisationID"].Visible = false;
            Author_dgv.Columns["ID"].ReadOnly = true;
            Author_dgv.Columns["Name"].ReadOnly = true;
            
        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor newAuthor = new AddAuthor(authorNames);
            if (newAuthor.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addAuthor(mPaperID, newAuthor.NewScientist))
                    MessageBox.Show("Such author already exists");
                AuthorRefresh_Click(null, null);
            }
        }

        private void deleteAuthor_Click(object sender, EventArgs e)
        {
            DeleteAuthor deleteAuthor = new DeleteAuthor();
            if (deleteAuthor.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteAuthor(deleteAuthor.ID))
                    MessageBox.Show("Such author does not exist");
                AuthorRefresh_Click(null, null);
            }
        }

        private void authorNameFilter_txbx_TextChanged(object sender, EventArgs e)
        {
            AuthorRefresh_Click(null, null);
        }
    }
}
