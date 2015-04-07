namespace PapersDB
{
    partial class DeleteOrganisation
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
            this.delOrg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // orgID_txbx
            // 
            this.orgID_txbx.Location = new System.Drawing.Point(93, 28);
            this.orgID_txbx.Name = "orgID_txbx";
            this.orgID_txbx.Size = new System.Drawing.Size(133, 20);
            this.orgID_txbx.TabIndex = 7;
            // 
            // delOrg_btn
            // 
            this.delOrg_btn.Location = new System.Drawing.Point(93, 91);
            this.delOrg_btn.Name = "delOrg_btn";
            this.delOrg_btn.Size = new System.Drawing.Size(75, 23);
            this.delOrg_btn.TabIndex = 6;
            this.delOrg_btn.Text = "Delete";
            this.delOrg_btn.UseVisualStyleBackColor = true;
            this.delOrg_btn.Click += new System.EventHandler(this.delOrg_btn_Click);
            // 
            // DeleteOrganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orgID_txbx);
            this.Controls.Add(this.delOrg_btn);
            this.Name = "DeleteOrganisation";
            this.Text = "DeleteOrganisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orgID_txbx;
        private System.Windows.Forms.Button delOrg_btn;
    }
}