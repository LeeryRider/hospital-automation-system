
namespace TEMP
{
    partial class Hastabilgi
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
            this.randevual1 = new System.Windows.Forms.Button();
            this.bulgu = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randevual1
            // 
            this.randevual1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevual1.Location = new System.Drawing.Point(85, 199);
            this.randevual1.Name = "randevual1";
            this.randevual1.Size = new System.Drawing.Size(355, 42);
            this.randevual1.TabIndex = 29;
            this.randevual1.Text = "Randevu Al";
            this.randevual1.UseVisualStyleBackColor = true;
            this.randevual1.Click += new System.EventHandler(this.randevual1_Click);
            // 
            // bulgu
            // 
            this.bulgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulgu.Location = new System.Drawing.Point(85, 276);
            this.bulgu.Name = "bulgu";
            this.bulgu.Size = new System.Drawing.Size(355, 42);
            this.bulgu.TabIndex = 30;
            this.bulgu.Text = "Sonuçlar ve Reçeteler";
            this.bulgu.UseVisualStyleBackColor = true;
            this.bulgu.Click += new System.EventHandler(this.bulgu_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b.Location = new System.Drawing.Point(145, 79);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(226, 33);
            this.b.TabIndex = 32;
            this.b.Text = "Hasta Bilgi Sistem";
            // 
            // Hastabilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(523, 399);
            this.Controls.Add(this.b);
            this.Controls.Add(this.bulgu);
            this.Controls.Add(this.randevual1);
            this.Name = "Hastabilgi";
            this.Text = "Hasta Bilgi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randevual1;
        private System.Windows.Forms.Button bulgu;
        private System.Windows.Forms.Label b;
    }
}