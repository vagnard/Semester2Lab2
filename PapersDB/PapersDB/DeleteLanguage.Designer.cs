namespace PapersDB
{
    partial class DeleteLanguage
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
            this.languageID_txbx = new System.Windows.Forms.TextBox();
            this.delLanguage_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // languageID_txbx
            // 
            this.languageID_txbx.Location = new System.Drawing.Point(91, 23);
            this.languageID_txbx.Name = "languageID_txbx";
            this.languageID_txbx.Size = new System.Drawing.Size(133, 20);
            this.languageID_txbx.TabIndex = 7;
            // 
            // delLanguage_btn
            // 
            this.delLanguage_btn.Location = new System.Drawing.Point(91, 86);
            this.delLanguage_btn.Name = "delLanguage_btn";
            this.delLanguage_btn.Size = new System.Drawing.Size(75, 23);
            this.delLanguage_btn.TabIndex = 6;
            this.delLanguage_btn.Text = "Delete";
            this.delLanguage_btn.UseVisualStyleBackColor = true;
            this.delLanguage_btn.Click += new System.EventHandler(this.delLanguage_btn_Click);
            // 
            // DeleteLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageID_txbx);
            this.Controls.Add(this.delLanguage_btn);
            this.Name = "DeleteLanguage";
            this.Text = "DeleteLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox languageID_txbx;
        private System.Windows.Forms.Button delLanguage_btn;
    }
}