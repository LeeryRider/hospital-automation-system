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
    public partial class Bulgular : Form
    {
        public Bulgular()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hastabilgi hst = new Hastabilgi();
            hst.Show();
            this.Hide();
        }
    }
}
