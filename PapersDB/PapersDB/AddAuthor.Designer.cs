namespace PapersDB
{
    partial class AddAuthor
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
            this.addAuthor_btn = new System.Windows.Forms.Button();
            this.authorNames_cmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Scientist";
            // 
            // addAuthor_btn
            // 
            this.addAuthor_btn.Location = new System.Drawing.Point(108, 93);
            this.addAuthor_btn.Name = "addAuthor_btn";
            this.addAuthor_btn.Size = new System.Drawing.Size(83, 25);
            this.addAuthor_btn.TabIndex = 11;
            this.addAuthor_btn.Text = "Add";
            this.addAuthor_btn.UseVisualStyleBackColor = true;
            this.addAuthor_btn.Click += new System.EventHandler(this.addAuthor_btn_Click);
            // 
            // authorNames_cmbx
            // 
            this.authorNames_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorNames_cmbx.FormattingEnabled = true;
            this.authorNames_cmbx.Location = new System.Drawing.Point(108, 26);
            this.authorNames_cmbx.Name = "authorNames_cmbx";
            this.authorNames_cmbx.Size = new System.Drawing.Size(159, 21);
            this.authorNames_cmbx.TabIndex = 10;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addAuthor_btn);
            this.Controls.Add(this.authorNames_cmbx);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAuthor_btn;
        private System.Windows.Forms.ComboBox authorNames_cmbx;
    }
}