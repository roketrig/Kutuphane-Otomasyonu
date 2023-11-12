using Kutuphane_Otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarım = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            string kullaniciadi, sifre = "";

            kullaniciadi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;
            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower() == kisi.getkullanici_adi() && sifre.ToLower() == kisi.getsifre() && kisi.Yetki =="admin")
                {
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarım);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getkullanici_adi() && sifre.ToLower() == kisi.getsifre() && kisi.Yetki == "uye")
                {
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarım);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }


            }
            if (!kontrol)
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz yanlış...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Üyelik işlemleri

            kisilerim.Add(new Kisi(2,"Elif","Olur", DateTime.Now, "elif", "123", "admin"));
            kisilerim.Add(new Kisi(3,"Mehmet","Yılmaz", DateTime.Now, "mehmet", "426624", "admin"));
            kisilerim.Add(new Kisi(4,"Semih","Polat", DateTime.Now, "polat", "0004", "uye"));

            //Kitap işlemleri
            kitaplarım.Add(new Kitap(1, "İşte Hastane", "Yaşar Yıldırım", "Türkçe", "Destek Yayınları", "Yönetim", 20, 224, 2023));
            kitaplarım.Add(new Kitap(2, "Nutuk", "Mustafa Kemal Atatürk", "Türkçe", "Ren Kitap", "Tarih", 30, 658, 2022));
            kitaplarım.Add(new Kitap(3, "Gece Yarısı Kütüphanesi", "Matt Haig", "Türkçe", "Domingo Yayınevi", "Roman", 10, 296, 2021));
            kitaplarım.Add(new Kitap(4, "Baba ve Piç", "Elif Şafak", "Türkçe", "Destek Yayınları", "Roman", 20, 350, 2020));

        }
    }
}
