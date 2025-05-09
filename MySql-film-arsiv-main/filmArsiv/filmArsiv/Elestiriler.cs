using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmArsiv
{
    public partial class Elestiriler : Form
    {
        public Elestiriler()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";

        private void dgvEles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Elestiriler_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();
                string sorgu = "SELECT filmler.film_ad,elestiriler.elestiri_metin,elestiriler.puan,elestiriler.elestiri_tarihi,elestiriler.elestirmen FROM elestiriler JOIN filmler ON filmler.film_id=elestiriler.film_id";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);

                MySqlDataAdapter adaptor = new MySqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);

                dgvEles.DataSource = tablo;

            }




            
        }
    }
}
