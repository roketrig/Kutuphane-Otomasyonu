using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otomasyonu.Model
{
    public class Kisi
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public string Kullanici_adi { get; set; }
        public string Kullanici_sifre { get; set; }
        public string Yetki { get; set; }

        public Kisi()
        {

        }
        public Kisi(int ıD, string isım, string soyisim, DateTime olusturmaTarih, string kullanici_adi, string kullanici_sifre, string yetki)
        {
            this.ID = ıD;
            this.isim = isım;
            this.soyisim = soyisim;
            this.olusturmaTarih = olusturmaTarih;
            this.Kullanici_adi = kullanici_adi;
            this.Kullanici_sifre = kullanici_sifre;
            this.Yetki = yetki;
        }
        public void setId(int polly)
        { 
            this.ID = polly; 
        }
        public int getId()
        {
            return this.ID;
        }
        public void setisim(string isim)
        {
            this.isim = isim;
        }
        public string getisim()
        {
            return this.isim;
        }
        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }
        public void setOlusturmaTarihi(DateTime olusturmaTarihi)
        {
            this.olusturmaTarih = olusturmaTarihi;
        }
        public DateTime getOlusturmaTarih()
        {
            return this.olusturmaTarih;
        }
        public void setkullanici_adi(string kullanici_adi)
        {
            this.Kullanici_adi = kullanici_adi;
        }
        public string getkullanici_adi()
        {
            return this.Kullanici_adi;
        }
        public void setsifre(string sifre)
        {
            this.Kullanici_sifre = sifre;
        }
        public string getsifre()
        {
            return this.Kullanici_sifre;
        }
        public void setYetki(string yetki)
        {
            this.Yetki = yetki;
        }
        public string getYetki()
        {
               return (this.Yetki);
        }
        public override string ToString()
        {
            return "İsim - Soyisim :" + this.isim + " " + this.soyisim;
        }
    }
}
