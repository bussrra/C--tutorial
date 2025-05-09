using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace button._49
{
    internal class Kitap
    {
        int id;
        string kAd;
        string yazar;
        string sayfa;
        string tur;
        DateTime tarih;
        bool cilt;

        public int Id { get => id; set => id = value; }
        public string KAd { get => kAd; set => kAd = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string Sayfa { get => sayfa; set => sayfa = value; }
        public string Tur { get => tur; set => tur = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Cilt { get => cilt; set => cilt = value; }

        public Kitap(int id, string kAd, string yazar, string sayfa, string tur, DateTime tarih, bool cilt)
        {
            this.id = id;
            this.kAd = kAd;
            this.yazar = yazar;
            this.sayfa = sayfa;
            this.tur = tur;
            this.tarih = tarih;
            this.cilt = cilt;
        }
    }
}
