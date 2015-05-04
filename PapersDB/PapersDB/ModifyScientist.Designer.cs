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
            this.modifySci_btn.Location = new System.Drawing.Point(103, 185);
            this.modifySci_btn.Name = "modifySci_btn";
            this.modifySci_btn.Size = new System.Drawing.Size(83, 25);
            this.modifySci_btn.TabIndex = 26;
            this.modifySci_btn.Text = "Modify";
            this.modifySci_btn.UseVisualStyleBackColor = true;
            this.modifySci_btn.Click += new System.EventHandler(this.modifySci_btn_Click);
            // 
            // sciHind_txbx
            // 
            this.sciHind_txbx.Location = new System.Drawing.Point(103, 144);
            this.sciHind_txbx.Name = "sciHind_txbx";
            this.sciHind_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciHind_txbx.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "H-index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Organisation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Name";
            // 
            // sciOrg_cmbx
            // 
            this.sciOrg_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sciOrg_cmbx.FormattingEnabled = true;
            this.sciOrg_cmbx.Location = new System.Drawing.Point(103, 60);
            this.sciOrg_cmbx.Name = "sciOrg_cmbx";
            this.sciOrg_cmbx.Size = new System.Drawing.Size(159, 21);
            this.sciOrg_cmbx.TabIndex = 32;
            // 
            // sciEmail_txbx
            // 
            this.sciEmail_txbx.Location = new System.Drawing.Point(103, 101);
            this.sciEmail_txbx.Name = "sciEmail_txbx";
            this.sciEmail_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciEmail_txbx.TabIndex = 31;
            // 
            // sciName_txbx
            // 
            this.sciName_txbx.Location = new System.Drawing.Point(103, 20);
            this.sciName_txbx.Name = "sciName_txbx";
            this.sciName_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciName_txbx.TabIndex = 30;
            // 
            // ModifyScientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 238);
            this.Controls.Add(this.sciHind_txbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sciOrg_cmbx);
            this.Controls.Add(this.sciEmail_txbx);
            this.Controls.Add(this.sciName_txbx);
            this.Controls.Add(this.modifySci_btn);
            this.Name = "ModifyScientist";
            this.Text = "ModifyScientist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifySci_btn;
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