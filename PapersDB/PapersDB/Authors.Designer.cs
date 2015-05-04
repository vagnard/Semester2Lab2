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
            this.components = new System.ComponentModel.Container();
            this.Organisations = new System.Windows.Forms.TabPage();
            this.deleteAuthor = new System.Windows.Forms.Button();
            this.addAuthor = new System.Windows.Forms.Button();
            this.authorNameFilter_txbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorRefresh = new System.Windows.Forms.Button();
            this.Author_dgv = new System.Windows.Forms.DataGridView();
            this.abc = new System.Windows.Forms.TabControl();
            this.authspapersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorpaperidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organisations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Author_dgv)).BeginInit();
            this.abc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authspapersBindingSource)).BeginInit();
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
            // deleteAuthor
            // 
            this.deleteAuthor.Location = new System.Drawing.Point(169, 362);
            this.deleteAuthor.Name = "deleteAuthor";
            this.deleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.deleteAuthor.TabIndex = 7;
            this.deleteAuthor.Text = "Delete";
            this.deleteAuthor.UseVisualStyleBackColor = true;
            this.deleteAuthor.Click += new System.EventHandler(this.deleteAuthor_Click);
            // 
            // addAuthor
            // 
            this.addAuthor.Location = new System.Drawing.Point(88, 362);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(75, 23);
            this.addAuthor.TabIndex = 6;
            this.addAuthor.Text = "Add";
            this.addAuthor.UseVisualStyleBackColor = true;
            this.addAuthor.Click += new System.EventHandler(this.addAuthor_Click);
            // 
            // authorNameFilter_txbx
            // 
            this.authorNameFilter_txbx.Location = new System.Drawing.Point(3, 19);
            this.authorNameFilter_txbx.Name = "authorNameFilter_txbx";
            this.authorNameFilter_txbx.Size = new System.Drawing.Size(290, 20);
            this.authorNameFilter_txbx.TabIndex = 2;
            this.authorNameFilter_txbx.TextChanged += new System.EventHandler(this.authorNameFilter_txbx_TextChanged);
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
            // Author_dgv
            // 
            this.Author_dgv.AllowUserToAddRows = false;
            this.Author_dgv.AutoGenerateColumns = false;
            this.Author_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Author_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorpaperidDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn});
            this.Author_dgv.DataSource = this.authspapersBindingSource;
            this.Author_dgv.Location = new System.Drawing.Point(3, 45);
            this.Author_dgv.Name = "Author_dgv";
            this.Author_dgv.Size = new System.Drawing.Size(718, 311);
            this.Author_dgv.TabIndex = 0;
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
            // authspapersBindingSource
            // 
            this.authspapersBindingSource.DataSource = typeof(Common.Auths_papers);
            // 
            // authorpaperidDataGridViewTextBoxColumn
            // 
            this.authorpaperidDataGridViewTextBoxColumn.DataPropertyName = "author_paper_id";
            this.authorpaperidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.authorpaperidDataGridViewTextBoxColumn.Name = "authorpaperidDataGridViewTextBoxColumn";
            this.authorpaperidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "Author";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.authspapersBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource authspapersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorpaperidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;

    }
}