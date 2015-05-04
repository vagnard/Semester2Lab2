namespace PapersDB
{
    partial class ModifyLanguage
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
            this.label2 = new System.Windows.Forms.Label();
            this.languageName_txbx = new System.Windows.Forms.TextBox();
            this.modLanguage_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // languageName_txbx
            // 
            this.languageName_txbx.Location = new System.Drawing.Point(98, 31);
            this.languageName_txbx.Name = "languageName_txbx";
            this.languageName_txbx.Size = new System.Drawing.Size(133, 20);
            this.languageName_txbx.TabIndex = 14;
            // 
            // modLanguage_btn
            // 
            this.modLanguage_btn.Location = new System.Drawing.Point(98, 78);
            this.modLanguage_btn.Name = "modLanguage_btn";
            this.modLanguage_btn.Size = new System.Drawing.Size(75, 23);
            this.modLanguage_btn.TabIndex = 11;
            this.modLanguage_btn.Text = "Modify";
            this.modLanguage_btn.UseVisualStyleBackColor = true;
            this.modLanguage_btn.Click += new System.EventHandler(this.modLanguage_btn_Click);
            // 
            // ModifyLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 128);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.languageName_txbx);
            this.Controls.Add(this.modLanguage_btn);
            this.Name = "ModifyLanguage";
            this.Text = "ModifyLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox languageName_txbx;
        private System.Windows.Forms.Button modLanguage_btn;
    }
}