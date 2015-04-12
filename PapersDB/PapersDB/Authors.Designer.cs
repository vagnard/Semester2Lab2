namespace PapersDB
{
    partial class Authors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Organisations = new System.Windows.Forms.TabPage();
            this.Author_dgv = new System.Windows.Forms.DataGridView();
            this.AuthorRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.authorNameFilter_txbx = new System.Windows.Forms.TextBox();
            this.abc = new System.Windows.Forms.TabControl();
            this.addAuthor = new System.Windows.Forms.Button();
            this.deleteAuthor = new System.Windows.Forms.Button();
            this.Organisations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Author_dgv)).BeginInit();
            this.abc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Organisations
            // 
            this.Organisations.Controls.Add(this.deleteAuthor);
            this.Organisations.Controls.Add(this.addAuthor);
            this.Organisations.Controls.Add(this.authorNameFilter_txbx);
            this.Organisations.Controls.Add(this.label1);
            this.Organisations.Controls.Add(this.AuthorRefresh);
            this.Organisations.Controls.Add(this.Author_dgv);
            this.Organisations.Location = new System.Drawing.Point(4, 22);
            this.Organisations.Name = "Organisations";
            this.Organisations.Padding = new System.Windows.Forms.Padding(3);
            this.Organisations.Size = new System.Drawing.Size(726, 389);
            this.Organisations.TabIndex = 0;
            this.Organisations.Text = "Authors";
            this.Organisations.UseVisualStyleBackColor = true;
            // 
            // Author_dgv
            // 
            this.Author_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Author_dgv.Location = new System.Drawing.Point(3, 45);
            this.Author_dgv.Name = "Author_dgv";
            this.Author_dgv.Size = new System.Drawing.Size(718, 311);
            this.Author_dgv.TabIndex = 0;
            // 
            // AuthorRefresh
            // 
            this.AuthorRefresh.Location = new System.Drawing.Point(7, 362);
            this.AuthorRefresh.Name = "AuthorRefresh";
            this.AuthorRefresh.Size = new System.Drawing.Size(75, 23);
            this.AuthorRefresh.TabIndex = 1;
            this.AuthorRefresh.Text = "Refresh";
            this.AuthorRefresh.UseVisualStyleBackColor = true;
            this.AuthorRefresh.Click += new System.EventHandler(this.AuthorRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // authorNameFilter_txbx
            // 
            this.authorNameFilter_txbx.Location = new System.Drawing.Point(3, 19);
            this.authorNameFilter_txbx.Name = "authorNameFilter_txbx";
            this.authorNameFilter_txbx.Size = new System.Drawing.Size(290, 20);
            this.authorNameFilter_txbx.TabIndex = 2;
            this.authorNameFilter_txbx.TextChanged += new System.EventHandler(this.authorNameFilter_txbx_TextChanged);
            // 
            // abc
            // 
            this.abc.Controls.Add(this.Organisations);
            this.abc.Location = new System.Drawing.Point(-1, 0);
            this.abc.Name = "abc";
            this.abc.SelectedIndex = 0;
            this.abc.Size = new System.Drawing.Size(734, 415);
            this.abc.TabIndex = 2;
            // 
            // addAuthor
            // 
            this.addAuthor.Location = new System.Drawing.Point(88, 360);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(75, 23);
            this.addAuthor.TabIndex = 6;
            this.addAuthor.Text = "Add";
            this.addAuthor.UseVisualStyleBackColor = true;
            this.addAuthor.Click += new System.EventHandler(this.addAuthor_Click);
            // 
            // deleteAuthor
            // 
            this.deleteAuthor.Location = new System.Drawing.Point(186, 363);
            this.deleteAuthor.Name = "deleteAuthor";
            this.deleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.deleteAuthor.TabIndex = 7;
            this.deleteAuthor.Text = "Delete";
            this.deleteAuthor.UseVisualStyleBackColor = true;
            this.deleteAuthor.Click += new System.EventHandler(this.deleteAuthor_Click);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.abc);
            this.Name = "Authors";
            this.Text = "Authors";
            this.Organisations.ResumeLayout(false);
            this.Organisations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Author_dgv)).EndInit();
            this.abc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Organisations;
        private System.Windows.Forms.TextBox authorNameFilter_txbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthorRefresh;
        private System.Windows.Forms.DataGridView Author_dgv;
        private System.Windows.Forms.TabControl abc;
        private System.Windows.Forms.Button deleteAuthor;
        private System.Windows.Forms.Button addAuthor;

    }
}