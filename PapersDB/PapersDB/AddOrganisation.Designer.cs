namespace PapersDB
{
    partial class AddOrganisation
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
            this.orgName_txbx = new System.Windows.Forms.TextBox();
            this.orgWebsity_txbx = new System.Windows.Forms.TextBox();
            this.orgCountry_cmbx = new System.Windows.Forms.ComboBox();
            this.addOrg_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orgName_txbx
            // 
            this.orgName_txbx.Location = new System.Drawing.Point(95, 21);
            this.orgName_txbx.Name = "orgName_txbx";
            this.orgName_txbx.Size = new System.Drawing.Size(159, 20);
            this.orgName_txbx.TabIndex = 0;
            // 
            // orgWebsity_txbx
            // 
            this.orgWebsity_txbx.Location = new System.Drawing.Point(95, 102);
            this.orgWebsity_txbx.Name = "orgWebsity_txbx";
            this.orgWebsity_txbx.Size = new System.Drawing.Size(159, 20);
            this.orgWebsity_txbx.TabIndex = 2;
            // 
            // orgCountry_cmbx
            // 
            this.orgCountry_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgCountry_cmbx.FormattingEnabled = true;
            this.orgCountry_cmbx.Location = new System.Drawing.Point(95, 61);
            this.orgCountry_cmbx.Name = "orgCountry_cmbx";
            this.orgCountry_cmbx.Size = new System.Drawing.Size(159, 21);
            this.orgCountry_cmbx.TabIndex = 3;
            // 
            // addOrg_btn
            // 
            this.addOrg_btn.Location = new System.Drawing.Point(95, 154);
            this.addOrg_btn.Name = "addOrg_btn";
            this.addOrg_btn.Size = new System.Drawing.Size(83, 25);
            this.addOrg_btn.TabIndex = 4;
            this.addOrg_btn.Text = "Add";
            this.addOrg_btn.UseVisualStyleBackColor = true;
            this.addOrg_btn.Click += new System.EventHandler(this.addOrg_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Website";
            // 
            // AddOrganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addOrg_btn);
            this.Controls.Add(this.orgCountry_cmbx);
            this.Controls.Add(this.orgWebsity_txbx);
            this.Controls.Add(this.orgName_txbx);
            this.Name = "AddOrganisation";
            this.Text = "Add organisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orgName_txbx;
        private System.Windows.Forms.TextBox orgWebsity_txbx;
        private System.Windows.Forms.ComboBox orgCountry_cmbx;
        private System.Windows.Forms.Button addOrg_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}