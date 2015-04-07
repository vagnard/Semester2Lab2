namespace PapersDB
{
    partial class ModifySubject
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
            this.subjectName_txbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectID_txbx = new System.Windows.Forms.TextBox();
            this.modSubject_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // subjectName_txbx
            // 
            this.subjectName_txbx.Location = new System.Drawing.Point(96, 68);
            this.subjectName_txbx.Name = "subjectName_txbx";
            this.subjectName_txbx.Size = new System.Drawing.Size(133, 20);
            this.subjectName_txbx.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // subjectID_txbx
            // 
            this.subjectID_txbx.Location = new System.Drawing.Point(96, 30);
            this.subjectID_txbx.Name = "subjectID_txbx";
            this.subjectID_txbx.Size = new System.Drawing.Size(133, 20);
            this.subjectID_txbx.TabIndex = 17;
            // 
            // modSubject_btn
            // 
            this.modSubject_btn.Location = new System.Drawing.Point(96, 115);
            this.modSubject_btn.Name = "modSubject_btn";
            this.modSubject_btn.Size = new System.Drawing.Size(75, 23);
            this.modSubject_btn.TabIndex = 16;
            this.modSubject_btn.Text = "Modify";
            this.modSubject_btn.UseVisualStyleBackColor = true;
            this.modSubject_btn.Click += new System.EventHandler(this.modSubject_btn_Click);
            // 
            // ModifySubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectName_txbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectID_txbx);
            this.Controls.Add(this.modSubject_btn);
            this.Name = "ModifySubject";
            this.Text = "ModifySubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectName_txbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectID_txbx;
        private System.Windows.Forms.Button modSubject_btn;
    }
}