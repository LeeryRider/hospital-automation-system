
namespace TEMP
{
    partial class Hasta_ekranı
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.randevual = new System.Windows.Forms.Button();
            this.randevuall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kulak Burun Boğaz",
            "Kardiyoloji",
            "Pediatri",
            "Plastik Cerrahi",
            "Psikiyatri",
            "Ortopedi"});
            this.comboBox1.Location = new System.Drawing.Point(169, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.a.Location = new System.Drawing.Point(73, 147);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(90, 19);
            this.a.TabIndex = 20;
            this.a.Text = "Poliklinikler : ";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b.Location = new System.Drawing.Point(99, 192);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(64, 19);
            this.b.TabIndex = 22;
            this.b.Text = "Doktor : ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Doktor 1",
            "Doktor 2",
            "Doktor 3"});
            this.comboBox2.Location = new System.Drawing.Point(169, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 23);
            this.comboBox2.TabIndex = 21;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c.Location = new System.Drawing.Point(116, 239);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(46, 19);
            this.c.TabIndex = 24;
            this.c.Text = "Tarih :";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.d.Location = new System.Drawing.Point(116, 282);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(47, 19);
            this.d.TabIndex = 26;
            this.d.Text = "Saat : ";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "9.30",
            "10.30",
            "11.30",
            "13.30",
            "14.30",
            "15.30",
            "16.30"});
            this.comboBox4.Location = new System.Drawing.Point(169, 278);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(259, 23);
            this.comboBox4.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 23);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // randevual
            // 
            this.randevual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevual.Location = new System.Drawing.Point(73, 329);
            this.randevual.Name = "randevual";
            this.randevual.Size = new System.Drawing.Size(355, 42);
            this.randevual.TabIndex = 28;
            this.randevual.Text = "Randevu Al";
            this.randevual.UseVisualStyleBackColor = true;
            this.randevual.Click += new System.EventHandler(this.randevual_Click);
            // 
            // randevuall
            // 
            this.randevuall.AutoSize = true;
            this.randevuall.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.randevuall.Location = new System.Drawing.Point(169, 60);
            this.randevuall.Name = "randevuall";
            this.randevuall.Size = new System.Drawing.Size(199, 31);
            this.randevuall.TabIndex = 29;
            this.randevuall.Text = "Randevu Oluştur";
            // 
            // Hasta_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(510, 529);
            this.Controls.Add(this.randevuall);
            this.Controls.Add(this.randevual);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.comboBox1);
            this.Name = "Hasta_ekranı";
            this.Text = "Randevu Al";
            this.Load += new System.EventHandler(this.Hasta_ekranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button randevual;
        private System.Windows.Forms.Label randevuall;
    }
}