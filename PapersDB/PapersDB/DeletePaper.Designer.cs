namespace PapersDB
{
    partial class DeletePaper
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
            this.paperID_txbx = new System.Windows.Forms.TextBox();
            this.delPaper_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // paperID_txbx
            // 
            this.paperID_txbx.Location = new System.Drawing.Point(91, 28);
            this.paperID_txbx.Name = "paperID_txbx";
            this.paperID_txbx.Size = new System.Drawing.Size(133, 20);
            this.paperID_txbx.TabIndex = 10;
            // 
            // delPaper_btn
            // 
            this.delPaper_btn.Location = new System.Drawing.Point(91, 91);
            this.delPaper_btn.Name = "delPaper_btn";
            this.delPaper_btn.Size = new System.Drawing.Size(75, 23);
            this.delPaper_btn.TabIndex = 9;
            this.delPaper_btn.Text = "Delete";
            this.delPaper_btn.UseVisualStyleBackColor = true;
            this.delPaper_btn.Click += new System.EventHandler(this.delPaper_btn_Click);
            // 
            // DeletePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paperID_txbx);
            this.Controls.Add(this.delPaper_btn);
            this.Name = "DeletePaper";
            this.Text = "DeletePaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paperID_txbx;
        private System.Windows.Forms.Button delPaper_btn;
    }
}