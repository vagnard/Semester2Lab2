namespace PapersDB
{
    partial class AddCountry
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
            this.addCountry_btn = new System.Windows.Forms.Button();
            this.countryName_txbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCountry_btn
            // 
            this.addCountry_btn.Location = new System.Drawing.Point(92, 82);
            this.addCountry_btn.Name = "addCountry_btn";
            this.addCountry_btn.Size = new System.Drawing.Size(75, 23);
            this.addCountry_btn.TabIndex = 0;
            this.addCountry_btn.Text = "Add";
            this.addCountry_btn.UseVisualStyleBackColor = true;
            this.addCountry_btn.Click += new System.EventHandler(this.addCountry_btn_Click);
            // 
            // countryName_txbx
            // 
            this.countryName_txbx.Location = new System.Drawing.Point(92, 19);
            this.countryName_txbx.Name = "countryName_txbx";
            this.countryName_txbx.Size = new System.Drawing.Size(133, 20);
            this.countryName_txbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryName_txbx);
            this.Controls.Add(this.addCountry_btn);
            this.Name = "AddCountry";
            this.Text = "Add country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCountry_btn;
        private System.Windows.Forms.TextBox countryName_txbx;
        private System.Windows.Forms.Label label1;
    }
}