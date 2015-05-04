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
        BindingList<string> authorNames;

        public Authors()
        {
            InitializeComponent();
            AuthorRefresh_Click(null, null);
        }
        public Authors(AccessToPapers.AccessToPapers accessToPapers, int paperID, BindingList<string> authorNames)
        {
            this.accessToPapers = accessToPapers;
            this.authorNames = authorNames;
            mPaperID = paperID;
            InitializeComponent();
            AuthorRefresh_Click(null, null);
        }
        private void AuthorRefresh_Click(object sender, EventArgs e)
        {
            var allAuthors = accessToPapers.getAllAuthors(mPaperID, authorNameFilter_txbx.Text.Trim());

            authspapersBindingSource.DataSource = null;
            authspapersBindingSource.DataSource = allAuthors;

        }
        private void addAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor newAuthor = new AddAuthor(authorNames);
            if (newAuthor.ShowDialog() == DialogResult.OK)
            {
                newAuthor.NewAuthor.p_id = mPaperID;
                if (!accessToPapers.addAuthor(newAuthor.NewAuthor))
                    MessageBox.Show("Such author already exists");
                AuthorRefresh_Click(null, null);
            }
        }

        private void deleteAuthor_Click(object sender, EventArgs e)
        {
            Auths_papers delPaper = new Auths_papers();

            delPaper.author_paper_id = Convert.ToInt32(Author_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());

            accessToPapers.deleteAuthor(delPaper);
            
            AuthorRefresh_Click(null, null);
        }
        
        private void authorNameFilter_txbx_TextChanged(object sender, EventArgs e)
        {
            AuthorRefresh_Click(null, null);
        }
    }
}
