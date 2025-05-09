using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroList=new List<Tiyatro> ();

        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroList.Add(new Tiyatro(1, "İstanbul/Nişantaşı","Büşra ve Meryem", 50, 350, new DateTime(2023, 08, 08), true));
            tiyatroList.Add(new Tiyatro(2, "İstanbul/Eminönü","Meryem Bakkala Gİderken" ,45, 200, new DateTime(2023, 05, 09), false));
            tiyatroList.Add(new Tiyatro(3, "istanbul/Kadıköy", "Büşra'nın Gerçekleşemeyen Hayalleri",35, 250, new DateTime(2023, 02, 04), true));
            tiyatroList.Add(new Tiyatro(4, "İstanbul/Bakırköy","Herkes Evide Otursun", 55, 235, new DateTime(2023, 06, 10), false));
            tiyatroList.Add(new Tiyatro(5, "İstanbul/Küçükçekmece","Hayat Hiçbişey Demek", 50, 120, new DateTime(2023, 08, 8), false));


            dgvListe.DataSource = tiyatroList;

            



        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string sahne = cmbSahne.Text;
            string ad = cmbOyunAd.Text;
            decimal sure = nudSure.Value;
            double fiyat = Convert.ToInt32(txtFiyat.Text);
            DateTime tarih = dtpTarih.Value;
            bool muzikal = chkMuzikal.Checked;
            nudSure.Value = sure;

            Tiyatro yeniTiyatro = new Tiyatro(id, sahne, ad, sure, fiyat, tarih, muzikal);

            tiyatroList.Add(yeniTiyatro);

            
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            cmbOyunAd.Text = dgvListe.CurrentRow.Cells["ad"].Value.ToString();
            nudSure.Value = (decimal)dgvListe.CurrentRow.Cells["oyunSure"].Value;
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            chkMuzikal.Checked = (bool)dgvListe.CurrentRow.Cells["muzikal"].Value;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro=secilenSatir.DataBoundItem as Tiyatro;
            DialogResult dr = MessageBox.Show("Seçilen tiyatro silinsin mi ?", "TİYATROYU SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                tiyatroList.Remove(secilenTiyatro);

            }
            dgvListe.DataSource = tiyatroList.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir=dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro=secilenSatir.DataBoundItem as Tiyatro;
            int id = Convert.ToInt32(txtId.Text);
            string sahne = cmbSahne.Text;
            string ad = cmbOyunAd.Text;
            Decimal sure =nudSure.Value;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            DateTime tarih = dtpTarih.Value;
            bool muzikal = chkMuzikal.Checked;
            nudSure.Value= sure;

            secilenTiyatro.Id = id;
            secilenTiyatro.Sahne= sahne;
            secilenTiyatro.Ad= ad;
            secilenTiyatro.OyunSure= sure;
            secilenTiyatro.Fiyat= fiyat;
            secilenTiyatro.Tarih= tarih;
            secilenTiyatro.Muzikal= muzikal;

            dgvListe.DataSource = null;
            dgvListe.DataSource = tiyatroList.ToList();



            
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
