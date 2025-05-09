using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._54
{
    public partial class Form1 : Form
    {
        int sayacB = 100;
        int sayacS = 100;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayacB--;
            
            
            if (sayacB <=0)
            {
                timer1.Stop();
            }
            label1.Text=sayacB.ToString();
            if(sayacB <= 0)
            {
                label3.Text = "SİYAH KAZANDI";
            }

        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            timer2.Start();
           
        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayacS--;
            
            if (sayacS <= 0)
            {
                timer2.Stop();
            }
            label2.Text=sayacS.ToString();
            if(sayacS <= 0)
            {
                label3.Text = "BEYAZ KAZANDI";
            }
        }
    }
}
