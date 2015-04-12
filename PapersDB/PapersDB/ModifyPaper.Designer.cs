namespace PapersDB
{
    partial class ModifyPaper
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
            this.label4 = new System.Windows.Forms.Label();
            this.modifyPaper_btn = new System.Windows.Forms.Button();
            this.paperLanguage_cmbx = new System.Windows.Forms.ComboBox();
            this.paperName_txbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paperID_txbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paperSubject_cmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Title";
            // 
            // modifyPaper_btn
            // 
            this.modifyPaper_btn.Location = new System.Drawing.Point(106, 199);
            this.modifyPaper_btn.Name = "modifyPaper_btn";
            this.modifyPaper_btn.Size = new System.Drawing.Size(83, 25);
            this.modifyPaper_btn.TabIndex = 26;
            this.modifyPaper_btn.Text = "Modify";
            this.modifyPaper_btn.UseVisualStyleBackColor = true;
            this.modifyPaper_btn.Click += new System.EventHandler(this.modifyPaper_btn_Click);
            // 
            // paperLanguage_cmbx
            // 
            this.paperLanguage_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperLanguage_cmbx.FormattingEnabled = true;
            this.paperLanguage_cmbx.Location = new System.Drawing.Point(106, 106);
            this.paperLanguage_cmbx.Name = "paperLanguage_cmbx";
            this.paperLanguage_cmbx.Size = new System.Drawing.Size(159, 21);
            this.paperLanguage_cmbx.TabIndex = 25;
            // 
            // paperName_txbx
            // 
            this.paperName_txbx.Location = new System.Drawing.Point(106, 66);
            this.paperName_txbx.Name = "paperName_txbx";
            this.paperName_txbx.Size = new System.Drawing.Size(159, 20);
            this.paperName_txbx.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // paperID_txbx
            // 
            this.paperID_txbx.Location = new System.Drawing.Point(106, 23);
            this.paperID_txbx.Name = "paperID_txbx";
            this.paperID_txbx.Size = new System.Drawing.Size(159, 20);
            this.paperID_txbx.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Subject";
            // 
            // paperSubject_cmbx
            // 
            this.paperSubject_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperSubject_cmbx.FormattingEnabled = true;
            this.paperSubject_cmbx.Location = new System.Drawing.Point(106, 149);
            this.paperSubject_cmbx.Name = "paperSubject_cmbx";
            this.paperSubject_cmbx.Size = new System.Drawing.Size(159, 21);
            this.paperSubject_cmbx.TabIndex = 29;
            // 
            // ModifyPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paperSubject_cmbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifyPaper_btn);
            this.Controls.Add(this.paperLanguage_cmbx);
            this.Controls.Add(this.paperName_txbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paperID_txbx);
            this.Name = "ModifyPaper";
            this.Text = "ModifyPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifyPaper_btn;
        private System.Windows.Forms.ComboBox paperLanguage_cmbx;
        private System.Windows.Forms.TextBox paperName_txbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paperID_txbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paperSubject_cmbx;
    }
}