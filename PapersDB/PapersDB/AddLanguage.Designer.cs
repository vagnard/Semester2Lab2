namespace PapersDB
{
    partial class AddLanguage
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
            this.languageName_txbx = new System.Windows.Forms.TextBox();
            this.addLanguage_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // languageName_txbx
            // 
            this.languageName_txbx.Location = new System.Drawing.Point(74, 27);
            this.languageName_txbx.Name = "languageName_txbx";
            this.languageName_txbx.Size = new System.Drawing.Size(133, 20);
            this.languageName_txbx.TabIndex = 4;
            // 
            // addLanguage_btn
            // 
            this.addLanguage_btn.Location = new System.Drawing.Point(74, 90);
            this.addLanguage_btn.Name = "addLanguage_btn";
            this.addLanguage_btn.Size = new System.Drawing.Size(75, 23);
            this.addLanguage_btn.TabIndex = 3;
            this.addLanguage_btn.Text = "Add";
            this.addLanguage_btn.UseVisualStyleBackColor = true;
            this.addLanguage_btn.Click += new System.EventHandler(this.addLanguage_btn_Click);
            // 
            // AddLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageName_txbx);
            this.Controls.Add(this.addLanguage_btn);
            this.Name = "AddLanguage";
            this.Text = "AddLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox languageName_txbx;
        private System.Windows.Forms.Button addLanguage_btn;
    }
}