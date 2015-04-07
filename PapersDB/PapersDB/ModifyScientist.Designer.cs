namespace PapersDB
{
    partial class ModifyScientist
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
            this.modifySci_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sciID_txbx = new System.Windows.Forms.TextBox();
            this.sciHind_txbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sciOrg_cmbx = new System.Windows.Forms.ComboBox();
            this.sciEmail_txbx = new System.Windows.Forms.TextBox();
            this.sciName_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifySci_btn
            // 
            this.modifySci_btn.Location = new System.Drawing.Point(102, 235);
            this.modifySci_btn.Name = "modifySci_btn";
            this.modifySci_btn.Size = new System.Drawing.Size(83, 25);
            this.modifySci_btn.TabIndex = 26;
            this.modifySci_btn.Text = "Modify";
            this.modifySci_btn.UseVisualStyleBackColor = true;
            this.modifySci_btn.Click += new System.EventHandler(this.modifySci_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // sciID_txbx
            // 
            this.sciID_txbx.Location = new System.Drawing.Point(102, 30);
            this.sciID_txbx.Name = "sciID_txbx";
            this.sciID_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciID_txbx.TabIndex = 21;
            // 
            // sciHind_txbx
            // 
            this.sciHind_txbx.Location = new System.Drawing.Point(102, 194);
            this.sciHind_txbx.Name = "sciHind_txbx";
            this.sciHind_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciHind_txbx.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "H-index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Organisation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Name";
            // 
            // sciOrg_cmbx
            // 
            this.sciOrg_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sciOrg_cmbx.FormattingEnabled = true;
            this.sciOrg_cmbx.Location = new System.Drawing.Point(102, 110);
            this.sciOrg_cmbx.Name = "sciOrg_cmbx";
            this.sciOrg_cmbx.Size = new System.Drawing.Size(159, 21);
            this.sciOrg_cmbx.TabIndex = 32;
            // 
            // sciEmail_txbx
            // 
            this.sciEmail_txbx.Location = new System.Drawing.Point(102, 151);
            this.sciEmail_txbx.Name = "sciEmail_txbx";
            this.sciEmail_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciEmail_txbx.TabIndex = 31;
            // 
            // sciName_txbx
            // 
            this.sciName_txbx.Location = new System.Drawing.Point(102, 70);
            this.sciName_txbx.Name = "sciName_txbx";
            this.sciName_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciName_txbx.TabIndex = 30;
            // 
            // ModifyScientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 289);
            this.Controls.Add(this.sciHind_txbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sciOrg_cmbx);
            this.Controls.Add(this.sciEmail_txbx);
            this.Controls.Add(this.sciName_txbx);
            this.Controls.Add(this.modifySci_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sciID_txbx);
            this.Name = "ModifyScientist";
            this.Text = "ModifyScientist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifySci_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sciID_txbx;
        private System.Windows.Forms.TextBox sciHind_txbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sciOrg_cmbx;
        private System.Windows.Forms.TextBox sciEmail_txbx;
        private System.Windows.Forms.TextBox sciName_txbx;
    }
}