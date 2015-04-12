namespace PapersDB
{
    partial class DeleteAuthor
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
            this.authorID_txbx = new System.Windows.Forms.TextBox();
            this.delAuthor_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // authorID_txbx
            // 
            this.authorID_txbx.Location = new System.Drawing.Point(91, 25);
            this.authorID_txbx.Name = "authorID_txbx";
            this.authorID_txbx.Size = new System.Drawing.Size(133, 20);
            this.authorID_txbx.TabIndex = 7;
            // 
            // delAuthor_btn
            // 
            this.delAuthor_btn.Location = new System.Drawing.Point(91, 88);
            this.delAuthor_btn.Name = "delAuthor_btn";
            this.delAuthor_btn.Size = new System.Drawing.Size(75, 23);
            this.delAuthor_btn.TabIndex = 6;
            this.delAuthor_btn.Text = "Delete";
            this.delAuthor_btn.UseVisualStyleBackColor = true;
            this.delAuthor_btn.Click += new System.EventHandler(this.delAuthor_btn_Click);
            // 
            // DeleteAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorID_txbx);
            this.Controls.Add(this.delAuthor_btn);
            this.Name = "DeleteAuthor";
            this.Text = "DeleteAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorID_txbx;
        private System.Windows.Forms.Button delAuthor_btn;
    }
}