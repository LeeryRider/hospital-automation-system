using System;
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
    public partial class Lab : Form
    {
        public Lab()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorekran docek = new Doktorekran();
            docek.Show();
            this.Hide();
        }

        private void labtetkik_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tetkik Ataması Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reçete Yazdırıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
