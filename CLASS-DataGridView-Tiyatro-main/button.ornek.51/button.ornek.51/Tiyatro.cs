using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace button.ornek._51
{
    internal class Tiyatro
    {
        int id;
        string sahne;
        string ad;
        decimal oyunSure;
        double fiyat;
        DateTime tarih;
        bool muzikal;

        public int Id { get => id; set => id = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public string Ad { get => ad; set => ad = value; }
        public decimal OyunSure { get => oyunSure; set => oyunSure = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }

        public Tiyatro(int id, string sahne, string ad, decimal oyunSure, double fiyat, DateTime tarih, bool muzikal)
        {
            this.id = id;
            this.sahne = sahne;
            this.ad = ad;
            this.oyunSure = oyunSure;
            this.fiyat = fiyat;
            this.tarih = tarih;
            this.muzikal = muzikal;
        }
    }
}
