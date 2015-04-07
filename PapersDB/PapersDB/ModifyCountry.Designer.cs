namespace PapersDB
{
    partial class ModifyCountry
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
            this.countryID_txbx = new System.Windows.Forms.TextBox();
            this.modCountry_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countryName_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // countryID_txbx
            // 
            this.countryID_txbx.Location = new System.Drawing.Point(92, 45);
            this.countryID_txbx.Name = "countryID_txbx";
            this.countryID_txbx.Size = new System.Drawing.Size(133, 20);
            this.countryID_txbx.TabIndex = 7;
            // 
            // modCountry_btn
            // 
            this.modCountry_btn.Location = new System.Drawing.Point(92, 130);
            this.modCountry_btn.Name = "modCountry_btn";
            this.modCountry_btn.Size = new System.Drawing.Size(75, 23);
            this.modCountry_btn.TabIndex = 6;
            this.modCountry_btn.Text = "Modify";
            this.modCountry_btn.UseVisualStyleBackColor = true;
            this.modCountry_btn.Click += new System.EventHandler(this.modCountry_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // countryName_txbx
            // 
            this.countryName_txbx.Location = new System.Drawing.Point(92, 83);
            this.countryName_txbx.Name = "countryName_txbx";
            this.countryName_txbx.Size = new System.Drawing.Size(133, 20);
            this.countryName_txbx.TabIndex = 9;
            // 
            // ModifyCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryName_txbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryID_txbx);
            this.Controls.Add(this.modCountry_btn);
            this.Name = "ModifyCountry";
            this.Text = "ModifyCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryID_txbx;
        private System.Windows.Forms.Button modCountry_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryName_txbx;
    }
}