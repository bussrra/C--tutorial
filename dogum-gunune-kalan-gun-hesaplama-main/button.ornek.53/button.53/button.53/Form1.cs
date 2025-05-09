using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime kalan = DateTime.Now;
            DateTime gun = dateTimePicker1.Value;

            TimeSpan ts = gun-kalan;

            label1.Text = "DOĞUM GÜNÜN : "+ gun.ToShortDateString();
            label2.Text = "KALAN GÜN : " + ts.Days.ToString();


        }
    }
}
