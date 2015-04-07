namespace PapersDB
{
    partial class DeleteScientist
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
            this.sciID_txbx = new System.Windows.Forms.TextBox();
            this.delSci_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // sciID_txbx
            // 
            this.sciID_txbx.Location = new System.Drawing.Point(94, 34);
            this.sciID_txbx.Name = "sciID_txbx";
            this.sciID_txbx.Size = new System.Drawing.Size(133, 20);
            this.sciID_txbx.TabIndex = 10;
            // 
            // delSci_btn
            // 
            this.delSci_btn.Location = new System.Drawing.Point(94, 97);
            this.delSci_btn.Name = "delSci_btn";
            this.delSci_btn.Size = new System.Drawing.Size(75, 23);
            this.delSci_btn.TabIndex = 9;
            this.delSci_btn.Text = "Delete";
            this.delSci_btn.UseVisualStyleBackColor = true;
            this.delSci_btn.Click += new System.EventHandler(this.delSci_btn_Click);
            // 
            // DeleteScientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sciID_txbx);
            this.Controls.Add(this.delSci_btn);
            this.Name = "DeleteScientist";
            this.Text = "DeleteScientist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sciID_txbx;
        private System.Windows.Forms.Button delSci_btn;
    }
}