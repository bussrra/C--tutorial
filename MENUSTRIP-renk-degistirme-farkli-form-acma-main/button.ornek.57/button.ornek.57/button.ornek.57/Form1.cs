using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();
            
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
        }

        private void merhabaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Pink;
        }

        private void nasılsınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PowderBlue;
        }

        private void bendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumPurple;
        }

        private void iyiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void busraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusraEkle buseKLE = new BusraEkle();
            buseKLE.ShowDialog();
        }
    }
}
