namespace PapersDB
{
    partial class DeleteSubject
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
            this.subjectID_txbx = new System.Windows.Forms.TextBox();
            this.delSubject_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // subjectID_txbx
            // 
            this.subjectID_txbx.Location = new System.Drawing.Point(90, 27);
            this.subjectID_txbx.Name = "subjectID_txbx";
            this.subjectID_txbx.Size = new System.Drawing.Size(133, 20);
            this.subjectID_txbx.TabIndex = 10;
            // 
            // delSubject_btn
            // 
            this.delSubject_btn.Location = new System.Drawing.Point(90, 90);
            this.delSubject_btn.Name = "delSubject_btn";
            this.delSubject_btn.Size = new System.Drawing.Size(75, 23);
            this.delSubject_btn.TabIndex = 9;
            this.delSubject_btn.Text = "Delete";
            this.delSubject_btn.UseVisualStyleBackColor = true;
            this.delSubject_btn.Click += new System.EventHandler(this.delSubject_btn_Click);
            // 
            // DeleteSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectID_txbx);
            this.Controls.Add(this.delSubject_btn);
            this.Name = "DeleteSubject";
            this.Text = "DeleteSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectID_txbx;
        private System.Windows.Forms.Button delSubject_btn;
    }
}