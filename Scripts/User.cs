﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEMP
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş başarısız! Yanlış kullanıcı adı veya şifre","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Hastabilgi hst = new Hastabilgi();
            hst.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayıt kyt = new Kayıt();
            kyt.Show();
            this.Hide();
        }
    }
}
