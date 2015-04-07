namespace PapersDB
{
    partial class AddPaper
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
            this.label1 = new System.Windows.Forms.Label();
            this.addPaper_btn = new System.Windows.Forms.Button();
            this.subject_cmbx = new System.Windows.Forms.ComboBox();
            this.orgTitle_txbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.language_cmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // addPaper_btn
            // 
            this.addPaper_btn.Location = new System.Drawing.Point(103, 164);
            this.addPaper_btn.Name = "addPaper_btn";
            this.addPaper_btn.Size = new System.Drawing.Size(83, 25);
            this.addPaper_btn.TabIndex = 11;
            this.addPaper_btn.Text = "Add";
            this.addPaper_btn.UseVisualStyleBackColor = true;
            this.addPaper_btn.Click += new System.EventHandler(this.addPaper_btn_Click);
            // 
            // subject_cmbx
            // 
            this.subject_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject_cmbx.FormattingEnabled = true;
            this.subject_cmbx.Location = new System.Drawing.Point(103, 64);
            this.subject_cmbx.Name = "subject_cmbx";
            this.subject_cmbx.Size = new System.Drawing.Size(159, 21);
            this.subject_cmbx.TabIndex = 10;
            // 
            // orgTitle_txbx
            // 
            this.orgTitle_txbx.Location = new System.Drawing.Point(103, 24);
            this.orgTitle_txbx.Name = "orgTitle_txbx";
            this.orgTitle_txbx.Size = new System.Drawing.Size(159, 20);
            this.orgTitle_txbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Language";
            // 
            // language_cmbx
            // 
            this.language_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language_cmbx.FormattingEnabled = true;
            this.language_cmbx.Location = new System.Drawing.Point(103, 104);
            this.language_cmbx.Name = "language_cmbx";
            this.language_cmbx.Size = new System.Drawing.Size(159, 21);
            this.language_cmbx.TabIndex = 15;
            // 
            // AddPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.language_cmbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPaper_btn);
            this.Controls.Add(this.subject_cmbx);
            this.Controls.Add(this.orgTitle_txbx);
            this.Name = "AddPaper";
            this.Text = "AddPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPaper_btn;
        private System.Windows.Forms.ComboBox subject_cmbx;
        private System.Windows.Forms.TextBox orgTitle_txbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox language_cmbx;
    }
}