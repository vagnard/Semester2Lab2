namespace PapersDB
{
    partial class AddSubject
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
            this.subjectName_txbx = new System.Windows.Forms.TextBox();
            this.addSubject_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // subjectName_txbx
            // 
            this.subjectName_txbx.Location = new System.Drawing.Point(75, 29);
            this.subjectName_txbx.Name = "subjectName_txbx";
            this.subjectName_txbx.Size = new System.Drawing.Size(133, 20);
            this.subjectName_txbx.TabIndex = 4;
            // 
            // addSubject_btn
            // 
            this.addSubject_btn.Location = new System.Drawing.Point(75, 92);
            this.addSubject_btn.Name = "addSubject_btn";
            this.addSubject_btn.Size = new System.Drawing.Size(75, 23);
            this.addSubject_btn.TabIndex = 3;
            this.addSubject_btn.Text = "Add";
            this.addSubject_btn.UseVisualStyleBackColor = true;
            this.addSubject_btn.Click += new System.EventHandler(this.addSubject_btn_Click);
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectName_txbx);
            this.Controls.Add(this.addSubject_btn);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectName_txbx;
        private System.Windows.Forms.Button addSubject_btn;
    }
}