using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otomasyonu.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfasayisi { get; set; }
        public int basimYili { get; set; }

        public Kitap() { }
        public Kitap(int kitapid, string kitapIsim, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfasayisi, int basimYili)
        {
            this.kitapid = kitapid;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimYili = basimYili;
        }
        public int getkitapid()
        {
            return this.kitapid;
        }
        public string getkitapisim()
        {
            return this.kitapIsim;
        }
        public string getkitapyazar()
        {
            return this.kitapYazar;
        }
        public string getkitapdili()
        {
            return this.kitapDili;
        }
        public string getYayinevi()
        {
            return this.yayinEvi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfasayisi()
        {
            return this.sayfasayisi;
        }
        public int getbasimyili()
        {
            return this.basimYili;
        }
    }
}
