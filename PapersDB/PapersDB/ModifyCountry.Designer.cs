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
            this.modCountry_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countryName_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modCountry_btn
            // 
            this.modCountry_btn.Location = new System.Drawing.Point(91, 78);
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
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // countryName_txbx
            // 
            this.countryName_txbx.Location = new System.Drawing.Point(91, 31);
            this.countryName_txbx.Name = "countryName_txbx";
            this.countryName_txbx.Size = new System.Drawing.Size(133, 20);
            this.countryName_txbx.TabIndex = 9;
            // 
            // ModifyCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 123);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryName_txbx);
            this.Controls.Add(this.modCountry_btn);
            this.Name = "ModifyCountry";
            this.Text = "ModifyCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modCountry_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryName_txbx;
    }
}