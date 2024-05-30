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
    public partial class Hastabilgi : Form
    {
        public Hastabilgi()
        {
            InitializeComponent();
        }

        private void randevual1_Click(object sender, EventArgs e)
        {
            Hasta_ekranı hst1 = new Hasta_ekranı();
            hst1.Show();
            this.Hide();
        }

        private void bulgu_Click(object sender, EventArgs e)
        {
            Bulgular blg1 = new Bulgular();
            blg1.Show();
            this.Hide();
        }
    }
}
