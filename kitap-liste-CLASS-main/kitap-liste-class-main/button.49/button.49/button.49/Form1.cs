using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitap;
        List<Kitap> kitapListe=new List<Kitap>();

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListe.Add(new Kitap(1, "Hayat", "Meryem","2405", "Romantik", new DateTime(2004, 1, 20), false));
            kitapListe.Add(new Kitap(2, "Meryem'in Rüyaları", "Ayda","4740", "Aksiyon", new DateTime(2020, 10, 30), true));
            kitapListe.Add(new Kitap(3, "Büşra'nın Düşlari", "Büsra","2550", "Eğlence", new DateTime(2021, 3, 10), true));
            kitapListe.Add(new Kitap(4, "Okul Dışında Hayat", "Elmas","430", "Romantik", new DateTime(2019, 8, 2), true));

            dgvListe.DataSource = kitapListe;

        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtAd.Text = dgvListe.CurrentRow.Cells["kAd"].Value.ToString();
            txtYazar.Text = dgvListe.CurrentRow.Cells["yazar"].Value.ToString();
            txtSayfa.Text = dgvListe.CurrentRow.Cells["sayfa"].Value.ToString();
            cmbTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            chkCilt.Checked = (bool)dgvListe.CurrentRow.Cells["cilt"].Value;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string kAd=txtAd.Text;
            string yazar=txtYazar.Text;
            string sayfa=txtSayfa.Text;
            string tur=cmbTur.Text;
            DateTime tarih = dtpTarih.Value;
            bool cilt=chkCilt.Checked;

            Kitap yeniKitap = new Kitap(id, kAd, yazar, sayfa, tur, tarih, cilt);

            kitapListe.Add(yeniKitap);
            dgvListe.DataSource = kitapListe.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Kitap secilenKitap=secilenSatir.DataBoundItem as Kitap;
            DialogResult kontrol = MessageBox.Show("secilen kitap silinsin mi?","kitabı sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kontrol == DialogResult.Yes)
            {
                kitapListe.Remove(secilenKitap);
            }
            dgvListe.DataSource = kitapListe.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir=dgvListe.SelectedRows[0];
            Kitap secilenKitap=secilenSatir.DataBoundItem as Kitap;

            int id = Convert.ToInt32(txtId.Text);
            string kAd = txtAd.Text;
            string yazar = txtYazar.Text;
            string sayfa = txtSayfa.Text;
            string tur = cmbTur.Text;
            DateTime tarih = dtpTarih.Value;
            bool cilt = chkCilt.Checked;

            secilenKitap.Id = id;
            secilenKitap.KAd= kAd;
            secilenKitap.Yazar = yazar;
            secilenKitap.Sayfa= sayfa;
            secilenKitap.Tur= tur;
            secilenKitap.Tarih = tarih;
            secilenKitap.Cilt= cilt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
