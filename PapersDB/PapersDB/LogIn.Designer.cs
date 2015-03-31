namespace PapersDB
{
    partial class LogIn
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
            this.SQL_rdbtn = new System.Windows.Forms.RadioButton();
            this.XML_rdbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SQL_gpbox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UseWinAuth_chbx = new System.Windows.Forms.CheckBox();
            this.ConnectionString_txbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Password_txbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Login_txbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InitCatalog_txbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataSource_txbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XML_gpbox = new System.Windows.Forms.GroupBox();
            this.ChooseXMLFile_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.XMLFile_txbx = new System.Windows.Forms.TextBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SQL_gpbox.SuspendLayout();
            this.XML_gpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQL_rdbtn
            // 
            this.SQL_rdbtn.AutoSize = true;
            this.SQL_rdbtn.Location = new System.Drawing.Point(156, 19);
            this.SQL_rdbtn.Name = "SQL_rdbtn";
            this.SQL_rdbtn.Size = new System.Drawing.Size(46, 17);
            this.SQL_rdbtn.TabIndex = 0;
            this.SQL_rdbtn.TabStop = true;
            this.SQL_rdbtn.Text = "SQL";
            this.SQL_rdbtn.UseVisualStyleBackColor = true;
            // 
            // XML_rdbtn
            // 
            this.XML_rdbtn.AutoSize = true;
            this.XML_rdbtn.Location = new System.Drawing.Point(268, 19);
            this.XML_rdbtn.Name = "XML_rdbtn";
            this.XML_rdbtn.Size = new System.Drawing.Size(47, 17);
            this.XML_rdbtn.TabIndex = 1;
            this.XML_rdbtn.TabStop = true;
            this.XML_rdbtn.Text = "XML";
            this.XML_rdbtn.UseVisualStyleBackColor = true;
            this.XML_rdbtn.CheckedChanged += new System.EventHandler(this.XML_rdbtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SQL_rdbtn);
            this.groupBox1.Controls.Add(this.XML_rdbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose data source type";
            // 
            // SQL_gpbox
            // 
            this.SQL_gpbox.Controls.Add(this.label6);
            this.SQL_gpbox.Controls.Add(this.UseWinAuth_chbx);
            this.SQL_gpbox.Controls.Add(this.ConnectionString_txbx);
            this.SQL_gpbox.Controls.Add(this.label5);
            this.SQL_gpbox.Controls.Add(this.Password_txbx);
            this.SQL_gpbox.Controls.Add(this.label4);
            this.SQL_gpbox.Controls.Add(this.Login_txbx);
            this.SQL_gpbox.Controls.Add(this.label3);
            this.SQL_gpbox.Controls.Add(this.InitCatalog_txbx);
            this.SQL_gpbox.Controls.Add(this.label2);
            this.SQL_gpbox.Controls.Add(this.DataSource_txbx);
            this.SQL_gpbox.Controls.Add(this.label1);
            this.SQL_gpbox.Location = new System.Drawing.Point(12, 68);
            this.SQL_gpbox.Name = "SQL_gpbox";
            this.SQL_gpbox.Size = new System.Drawing.Size(478, 225);
            this.SQL_gpbox.TabIndex = 7;
            this.SQL_gpbox.TabStop = false;
            this.SQL_gpbox.Text = "SQL connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Windows authentication";
            // 
            // UseWinAuth_chbx
            // 
            this.UseWinAuth_chbx.AutoSize = true;
            this.UseWinAuth_chbx.Location = new System.Drawing.Point(156, 81);
            this.UseWinAuth_chbx.Name = "UseWinAuth_chbx";
            this.UseWinAuth_chbx.Size = new System.Drawing.Size(15, 14);
            this.UseWinAuth_chbx.TabIndex = 10;
            this.UseWinAuth_chbx.UseVisualStyleBackColor = true;
            this.UseWinAuth_chbx.CheckedChanged += new System.EventHandler(this.ConnectionParam_txbx_TextChanged);
            // 
            // ConnectionString_txbx
            // 
            this.ConnectionString_txbx.Location = new System.Drawing.Point(156, 179);
            this.ConnectionString_txbx.Name = "ConnectionString_txbx";
            this.ConnectionString_txbx.ReadOnly = true;
            this.ConnectionString_txbx.Size = new System.Drawing.Size(316, 20);
            this.ConnectionString_txbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Connection string";
            // 
            // Password_txbx
            // 
            this.Password_txbx.Location = new System.Drawing.Point(156, 124);
            this.Password_txbx.Name = "Password_txbx";
            this.Password_txbx.Size = new System.Drawing.Size(166, 20);
            this.Password_txbx.TabIndex = 7;
            this.Password_txbx.TextChanged += new System.EventHandler(this.ConnectionParam_txbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User password";
            // 
            // Login_txbx
            // 
            this.Login_txbx.Location = new System.Drawing.Point(156, 98);
            this.Login_txbx.Name = "Login_txbx";
            this.Login_txbx.Size = new System.Drawing.Size(166, 20);
            this.Login_txbx.TabIndex = 5;
            this.Login_txbx.TextChanged += new System.EventHandler(this.ConnectionParam_txbx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User login";
            // 
            // InitCatalog_txbx
            // 
            this.InitCatalog_txbx.Location = new System.Drawing.Point(156, 58);
            this.InitCatalog_txbx.Name = "InitCatalog_txbx";
            this.InitCatalog_txbx.Size = new System.Drawing.Size(166, 20);
            this.InitCatalog_txbx.TabIndex = 3;
            this.InitCatalog_txbx.Text = "BasePapers";
            this.InitCatalog_txbx.TextChanged += new System.EventHandler(this.ConnectionParam_txbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial catalog";
            // 
            // DataSource_txbx
            // 
            this.DataSource_txbx.Location = new System.Drawing.Point(156, 32);
            this.DataSource_txbx.Name = "DataSource_txbx";
            this.DataSource_txbx.Size = new System.Drawing.Size(166, 20);
            this.DataSource_txbx.TabIndex = 1;
            this.DataSource_txbx.Text = "VAGNARD-ПК\\SQLEXPRESS";
            this.DataSource_txbx.TextChanged += new System.EventHandler(this.ConnectionParam_txbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data source";
            // 
            // XML_gpbox
            // 
            this.XML_gpbox.Controls.Add(this.ChooseXMLFile_btn);
            this.XML_gpbox.Controls.Add(this.label7);
            this.XML_gpbox.Controls.Add(this.XMLFile_txbx);
            this.XML_gpbox.Location = new System.Drawing.Point(14, 299);
            this.XML_gpbox.Name = "XML_gpbox";
            this.XML_gpbox.Size = new System.Drawing.Size(476, 83);
            this.XML_gpbox.TabIndex = 8;
            this.XML_gpbox.TabStop = false;
            this.XML_gpbox.Text = "XML connection";
            // 
            // ChooseXMLFile_btn
            // 
            this.ChooseXMLFile_btn.Location = new System.Drawing.Point(326, 51);
            this.ChooseXMLFile_btn.Name = "ChooseXMLFile_btn";
            this.ChooseXMLFile_btn.Size = new System.Drawing.Size(75, 23);
            this.ChooseXMLFile_btn.TabIndex = 2;
            this.ChooseXMLFile_btn.Text = "Search";
            this.ChooseXMLFile_btn.UseVisualStyleBackColor = true;
            this.ChooseXMLFile_btn.Click += new System.EventHandler(this.ChooseXMLFile_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "XML data source";
            // 
            // XMLFile_txbx
            // 
            this.XMLFile_txbx.Location = new System.Drawing.Point(154, 53);
            this.XMLFile_txbx.Name = "XMLFile_txbx";
            this.XMLFile_txbx.Size = new System.Drawing.Size(166, 20);
            this.XMLFile_txbx.TabIndex = 0;
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(302, 419);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(72, 23);
            this.Connect_btn.TabIndex = 9;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(410, 419);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(80, 23);
            this.Cancel_btn.TabIndex = 10;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 458);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.XML_gpbox);
            this.Controls.Add(this.SQL_gpbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SQL_gpbox.ResumeLayout(false);
            this.SQL_gpbox.PerformLayout();
            this.XML_gpbox.ResumeLayout(false);
            this.XML_gpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton SQL_rdbtn;
        private System.Windows.Forms.RadioButton XML_rdbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox SQL_gpbox;
        private System.Windows.Forms.CheckBox UseWinAuth_chbx;
        private System.Windows.Forms.TextBox ConnectionString_txbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Password_txbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login_txbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InitCatalog_txbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataSource_txbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox XML_gpbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox XMLFile_txbx;
        private System.Windows.Forms.Button ChooseXMLFile_btn;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}