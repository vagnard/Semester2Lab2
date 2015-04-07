namespace PapersDB
{
    partial class ModifyOrganisation
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
            this.label1 = new System.Windows.Forms.Label();
            this.orgID_txbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifyOrg_btn = new System.Windows.Forms.Button();
            this.orgCountry_cmbx = new System.Windows.Forms.ComboBox();
            this.orgWebsity_txbx = new System.Windows.Forms.TextBox();
            this.orgName_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // orgID_txbx
            // 
            this.orgID_txbx.Location = new System.Drawing.Point(93, 23);
            this.orgID_txbx.Name = "orgID_txbx";
            this.orgID_txbx.Size = new System.Drawing.Size(159, 20);
            this.orgID_txbx.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // modifyOrg_btn
            // 
            this.modifyOrg_btn.Location = new System.Drawing.Point(93, 199);
            this.modifyOrg_btn.Name = "modifyOrg_btn";
            this.modifyOrg_btn.Size = new System.Drawing.Size(83, 25);
            this.modifyOrg_btn.TabIndex = 17;
            this.modifyOrg_btn.Text = "Modify";
            this.modifyOrg_btn.UseVisualStyleBackColor = true;
            this.modifyOrg_btn.Click += new System.EventHandler(this.modifyOrg_btn_Click);
            // 
            // orgCountry_cmbx
            // 
            this.orgCountry_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgCountry_cmbx.FormattingEnabled = true;
            this.orgCountry_cmbx.Location = new System.Drawing.Point(93, 106);
            this.orgCountry_cmbx.Name = "orgCountry_cmbx";
            this.orgCountry_cmbx.Size = new System.Drawing.Size(159, 21);
            this.orgCountry_cmbx.TabIndex = 16;
            // 
            // orgWebsity_txbx
            // 
            this.orgWebsity_txbx.Location = new System.Drawing.Point(93, 147);
            this.orgWebsity_txbx.Name = "orgWebsity_txbx";
            this.orgWebsity_txbx.Size = new System.Drawing.Size(159, 20);
            this.orgWebsity_txbx.TabIndex = 15;
            // 
            // orgName_txbx
            // 
            this.orgName_txbx.Location = new System.Drawing.Point(93, 66);
            this.orgName_txbx.Name = "orgName_txbx";
            this.orgName_txbx.Size = new System.Drawing.Size(159, 20);
            this.orgName_txbx.TabIndex = 14;
            // 
            // ModifyOrganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifyOrg_btn);
            this.Controls.Add(this.orgCountry_cmbx);
            this.Controls.Add(this.orgWebsity_txbx);
            this.Controls.Add(this.orgName_txbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orgID_txbx);
            this.Name = "ModifyOrganisation";
            this.Text = "ModifyOrganisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orgID_txbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifyOrg_btn;
        private System.Windows.Forms.ComboBox orgCountry_cmbx;
        private System.Windows.Forms.TextBox orgWebsity_txbx;
        private System.Windows.Forms.TextBox orgName_txbx;
    }
}