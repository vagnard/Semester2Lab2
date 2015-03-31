namespace PapersDB
{
    partial class Client
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.abc = new System.Windows.Forms.TabControl();
            this.Organisations = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrgCountry_cmbx = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RefreshOrg = new System.Windows.Forms.Button();
            this.org_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CountriesRefresh_btn = new System.Windows.Forms.Button();
            this.countries_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.organisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.paperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basePapersDataSet = new PapersDB.BasePapersDataSet();
            this.abc.SuspendLayout();
            this.Organisations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.org_dgv)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countries_dgv)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basePapersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // abc
            // 
            this.abc.Controls.Add(this.Organisations);
            this.abc.Controls.Add(this.tabPage2);
            this.abc.Controls.Add(this.tabPage1);
            this.abc.Controls.Add(this.tabPage3);
            this.abc.Controls.Add(this.tabPage4);
            this.abc.Controls.Add(this.tabPage5);
            this.abc.Controls.Add(this.tabPage6);
            this.abc.Location = new System.Drawing.Point(1, 26);
            this.abc.Name = "abc";
            this.abc.SelectedIndex = 0;
            this.abc.Size = new System.Drawing.Size(734, 415);
            this.abc.TabIndex = 0;
            // 
            // Organisations
            // 
            this.Organisations.Controls.Add(this.label3);
            this.Organisations.Controls.Add(this.textBox2);
            this.Organisations.Controls.Add(this.label2);
            this.Organisations.Controls.Add(this.label1);
            this.Organisations.Controls.Add(this.OrgCountry_cmbx);
            this.Organisations.Controls.Add(this.textBox1);
            this.Organisations.Controls.Add(this.RefreshOrg);
            this.Organisations.Controls.Add(this.org_dgv);
            this.Organisations.Location = new System.Drawing.Point(4, 22);
            this.Organisations.Name = "Organisations";
            this.Organisations.Padding = new System.Windows.Forms.Padding(3);
            this.Organisations.Size = new System.Drawing.Size(726, 389);
            this.Organisations.TabIndex = 0;
            this.Organisations.Text = "Organisations";
            this.Organisations.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Website";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(439, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country";
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
            // OrgCountry_cmbx
            // 
            this.OrgCountry_cmbx.FormattingEnabled = true;
            this.OrgCountry_cmbx.Location = new System.Drawing.Point(299, 19);
            this.OrgCountry_cmbx.Name = "OrgCountry_cmbx";
            this.OrgCountry_cmbx.Size = new System.Drawing.Size(131, 21);
            this.OrgCountry_cmbx.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 2;
            // 
            // RefreshOrg
            // 
            this.RefreshOrg.Location = new System.Drawing.Point(7, 362);
            this.RefreshOrg.Name = "RefreshOrg";
            this.RefreshOrg.Size = new System.Drawing.Size(75, 23);
            this.RefreshOrg.TabIndex = 1;
            this.RefreshOrg.Text = "Refresh";
            this.RefreshOrg.UseVisualStyleBackColor = true;
            this.RefreshOrg.Click += new System.EventHandler(this.RefreshOrg_Click);
            // 
            // org_dgv
            // 
            this.org_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.org_dgv.Location = new System.Drawing.Point(3, 45);
            this.org_dgv.Name = "org_dgv";
            this.org_dgv.Size = new System.Drawing.Size(718, 311);
            this.org_dgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Papers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(726, 389);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Scientists";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(726, 389);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Languages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(726, 389);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Subjects";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.CountriesRefresh_btn);
            this.tabPage5.Controls.Add(this.countries_dgv);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(726, 389);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Countries";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // CountriesRefresh_btn
            // 
            this.CountriesRefresh_btn.Location = new System.Drawing.Point(7, 360);
            this.CountriesRefresh_btn.Name = "CountriesRefresh_btn";
            this.CountriesRefresh_btn.Size = new System.Drawing.Size(75, 23);
            this.CountriesRefresh_btn.TabIndex = 1;
            this.CountriesRefresh_btn.Text = "Refresh";
            this.CountriesRefresh_btn.UseVisualStyleBackColor = true;
            this.CountriesRefresh_btn.Click += new System.EventHandler(this.CountriesRefresh_btn_Click);
            // 
            // countries_dgv
            // 
            this.countries_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countries_dgv.Location = new System.Drawing.Point(3, 43);
            this.countries_dgv.Name = "countries_dgv";
            this.countries_dgv.Size = new System.Drawing.Size(718, 311);
            this.countries_dgv.TabIndex = 0;
            this.countries_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.countries_dgv_CellValueChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(726, 389);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Journals";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organisationToolStripMenuItem,
            this.paperToolStripMenuItem,
            this.scientistToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.journalToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(735, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // organisationToolStripMenuItem
            // 
            this.organisationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewOrg});
            this.organisationToolStripMenuItem.Name = "organisationToolStripMenuItem";
            this.organisationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.organisationToolStripMenuItem.Text = "Organisation";
            // 
            // addNewOrg
            // 
            this.addNewOrg.Name = "addNewOrg";
            this.addNewOrg.Size = new System.Drawing.Size(152, 22);
            this.addNewOrg.Text = "Add";
            this.addNewOrg.Click += new System.EventHandler(this.addNewOrg_Click);
            // 
            // paperToolStripMenuItem
            // 
            this.paperToolStripMenuItem.Name = "paperToolStripMenuItem";
            this.paperToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.paperToolStripMenuItem.Text = "Paper";
            // 
            // scientistToolStripMenuItem
            // 
            this.scientistToolStripMenuItem.Name = "scientistToolStripMenuItem";
            this.scientistToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.scientistToolStripMenuItem.Text = "Scientist";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCountryToolStripMenuItem,
            this.deleteCountryToolStripMenuItem});
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // addCountryToolStripMenuItem
            // 
            this.addCountryToolStripMenuItem.Name = "addCountryToolStripMenuItem";
            this.addCountryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addCountryToolStripMenuItem.Text = "Add";
            this.addCountryToolStripMenuItem.Click += new System.EventHandler(this.addCountryToolStripMenuItem_Click);
            // 
            // deleteCountryToolStripMenuItem
            // 
            this.deleteCountryToolStripMenuItem.Name = "deleteCountryToolStripMenuItem";
            this.deleteCountryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteCountryToolStripMenuItem.Text = "Delete";
            this.deleteCountryToolStripMenuItem.Click += new System.EventHandler(this.deleteCountryToolStripMenuItem_Click);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.journalToolStripMenuItem.Text = "Journal";
            // 
            // basePapersDataSet
            // 
            this.basePapersDataSet.DataSetName = "BasePapersDataSet";
            this.basePapersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 442);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Client";
            this.Text = "Form1";
            this.abc.ResumeLayout(false);
            this.Organisations.ResumeLayout(false);
            this.Organisations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.org_dgv)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countries_dgv)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basePapersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl abc;
        private System.Windows.Forms.TabPage Organisations;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView org_dgv;
        private System.Windows.Forms.Button RefreshOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrgCountry_cmbx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem organisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOrg;
        private System.Windows.Forms.ToolStripMenuItem paperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCountryToolStripMenuItem;
        private System.Windows.Forms.DataGridView countries_dgv;
        private System.Windows.Forms.Button CountriesRefresh_btn;
        private System.Windows.Forms.ToolStripMenuItem deleteCountryToolStripMenuItem;
        private BasePapersDataSet basePapersDataSet;
    }
}

