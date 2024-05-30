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
    public partial class Hasta_ekranı : Form
    {
        public Hasta_ekranı()
        {
            InitializeComponent();
        }

        private void Hasta_ekranı_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randevual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Randevu onaylandı!","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Randevu onaylanmadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
