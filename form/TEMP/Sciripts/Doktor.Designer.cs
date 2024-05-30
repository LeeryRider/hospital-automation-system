
namespace TEMP
{
    partial class Doktor
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
            this.doc = new System.Windows.Forms.Label();
            this.passworddoc = new System.Windows.Forms.Label();
            this.tckno1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doc.Location = new System.Drawing.Point(184, 94);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(164, 31);
            this.doc.TabIndex = 21;
            this.doc.Text = "Doktor Girişi ";
            // 
            // passworddoc
            // 
            this.passworddoc.AutoSize = true;
            this.passworddoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passworddoc.Location = new System.Drawing.Point(171, 256);
            this.passworddoc.Name = "passworddoc";
            this.passworddoc.Size = new System.Drawing.Size(48, 19);
            this.passworddoc.TabIndex = 20;
            this.passworddoc.Text = "Şifre : ";
            // 
            // tckno1
            // 
            this.tckno1.AutoSize = true;
            this.tckno1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tckno1.Location = new System.Drawing.Point(111, 213);
            this.tckno1.Name = "tckno1";
            this.tckno1.Size = new System.Drawing.Size(108, 19);
            this.tckno1.TabIndex = 19;
            this.tckno1.Text = "TC Kimlik No : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 23);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(111, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 42);
            this.button4.TabIndex = 15;
            this.button4.Text = "Giriş";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(510, 529);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.passworddoc);
            this.Controls.Add(this.tckno1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doc;
        private System.Windows.Forms.Label passworddoc;
        private System.Windows.Forms.Label tckno1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}