namespace PapersDB
{
    partial class DeleteCountry
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
            this.countryName_txbx = new System.Windows.Forms.TextBox();
            this.delCountry_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // countryName_txbx
            // 
            this.countryName_txbx.Location = new System.Drawing.Point(91, 22);
            this.countryName_txbx.Name = "countryName_txbx";
            this.countryName_txbx.Size = new System.Drawing.Size(133, 20);
            this.countryName_txbx.TabIndex = 4;
            // 
            // delCountry_btn
            // 
            this.delCountry_btn.Location = new System.Drawing.Point(91, 85);
            this.delCountry_btn.Name = "delCountry_btn";
            this.delCountry_btn.Size = new System.Drawing.Size(75, 23);
            this.delCountry_btn.TabIndex = 3;
            this.delCountry_btn.Text = "Delete";
            this.delCountry_btn.UseVisualStyleBackColor = true;
            this.delCountry_btn.Click += new System.EventHandler(this.delCountry_btn_Click);
            // 
            // DeleteCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryName_txbx);
            this.Controls.Add(this.delCountry_btn);
            this.Name = "DeleteCountry";
            this.Text = "DeleteCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryName_txbx;
        private System.Windows.Forms.Button delCountry_btn;
    }
}