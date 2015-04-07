namespace PapersDB
{
    partial class AddScientist
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addSci_btn = new System.Windows.Forms.Button();
            this.sciOrg_cmbx = new System.Windows.Forms.ComboBox();
            this.sciEmail_txbx = new System.Windows.Forms.TextBox();
            this.sciName_txbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sciHind_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Organisation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // addSci_btn
            // 
            this.addSci_btn.Location = new System.Drawing.Point(100, 205);
            this.addSci_btn.Name = "addSci_btn";
            this.addSci_btn.Size = new System.Drawing.Size(83, 25);
            this.addSci_btn.TabIndex = 11;
            this.addSci_btn.Text = "Add";
            this.addSci_btn.UseVisualStyleBackColor = true;
            this.addSci_btn.Click += new System.EventHandler(this.addSci_btn_Click);
            // 
            // sciOrg_cmbx
            // 
            this.sciOrg_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sciOrg_cmbx.FormattingEnabled = true;
            this.sciOrg_cmbx.Location = new System.Drawing.Point(100, 67);
            this.sciOrg_cmbx.Name = "sciOrg_cmbx";
            this.sciOrg_cmbx.Size = new System.Drawing.Size(159, 21);
            this.sciOrg_cmbx.TabIndex = 10;
            // 
            // sciEmail_txbx
            // 
            this.sciEmail_txbx.Location = new System.Drawing.Point(100, 108);
            this.sciEmail_txbx.Name = "sciEmail_txbx";
            this.sciEmail_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciEmail_txbx.TabIndex = 9;
            // 
            // sciName_txbx
            // 
            this.sciName_txbx.Location = new System.Drawing.Point(100, 27);
            this.sciName_txbx.Name = "sciName_txbx";
            this.sciName_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciName_txbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "H-index";
            // 
            // sciHind_txbx
            // 
            this.sciHind_txbx.Location = new System.Drawing.Point(100, 151);
            this.sciHind_txbx.Name = "sciHind_txbx";
            this.sciHind_txbx.Size = new System.Drawing.Size(159, 20);
            this.sciHind_txbx.TabIndex = 16;
            // 
            // AddScientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.sciHind_txbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSci_btn);
            this.Controls.Add(this.sciOrg_cmbx);
            this.Controls.Add(this.sciEmail_txbx);
            this.Controls.Add(this.sciName_txbx);
            this.Name = "AddScientist";
            this.Text = "AddScientist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSci_btn;
        private System.Windows.Forms.ComboBox sciOrg_cmbx;
        private System.Windows.Forms.TextBox sciEmail_txbx;
        private System.Windows.Forms.TextBox sciName_txbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sciHind_txbx;
    }
}