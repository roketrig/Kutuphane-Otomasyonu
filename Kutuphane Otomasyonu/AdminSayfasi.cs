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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi(List<Kisi> kisilerim,List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(),kisi.getisim(),kisi.getsoyisim(),kisi.getOlusturmaTarih(),kisi.getkullanici_adi(),kisi.getkullanici_adi(),kisi.getsifre(),kisi.getYetki());

            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getYayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text),txt_isim.Text,txt_soyisim.Text,maskedTextBox_date.Text,txt_kullaniciadi.Text,txt_sifre.Text,txt_yetki.Text);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_Uyeislemleri.Controls.Count; i++)
            {
                if (groupBox_Uyeislemleri.Controls[i] is TextBox || groupBox_Uyeislemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_Uyeislemleri.Controls[i].Text = string.Empty;
                }


            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void textleridoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_date.Text = dataGridView1.CurrentCell.Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tarih = maskedTextBox_date.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim, soyisim,tarih, kullaniciadi, sifre, yetki);

        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapisim = txt_kitapisim.Text;
            string kitapyazar = txt_kitapyazar.Text;
            string kitapdili=txt_kitapdili.Text;
            string yayinevi = txt_yayinevi.Text;
            string tur = txt_tur.Text;
            string adet = txt_adet.Text;
            string sayfasayisi = txt_sayfasayisi.Text;
            string basimyili = txt_basimyili.Text;
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid,kitapisim,kitapyazar,kitapdili,yayinevi, tur,adet,sayfasayisi,basimyili);
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text,txt_kitapisim.Text,txt_kitapyazar.Text,txt_kitapdili.Text,txt_yayinevi.Text,txt_tur.Text,txt_adet.Text,txt_sayfasayisi.Text,txt_basimyili.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupbox_kitapislemleri.Controls.Count; i++)
            {
                if (groupbox_kitapislemleri.Controls[i] is TextBox)
                {
                    groupbox_kitapislemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfasayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            Kisi hedefkisi = null;
            int secilenkisininid = Convert.ToInt32(txt_uyeara.Text);
            foreach (Kisi kisi in kisilerim)
            {
                if (kisi.getId() == secilenkisininid)
                {
                    hedefkisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getisim(), hedefkisi.getOlusturmaTarih(), hedefkisi.getkullanici_adi(), hedefkisi.getsifre(), hedefkisi.getYetki());
        }

        private void btn_uyeyenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getisim(), hedefkisi.getOlusturmaTarih(), hedefkisi.getkullanici_adi(), hedefkisi.getsifre(), hedefkisi.getYetki());
            }
        }

        private void txt_kitapara_TextChanged(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int kitapid = Convert.ToInt32(txt_kitapara.Text);
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid() == kitapid)
                {
                    hedefkitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getYayinevi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimyili());
        }

        private void txt_uyeara_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            foreach (Kitap hedefkitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitapid(), hedefkitap.getkitapisim(), hedefkitap.getkitapisim(), hedefkitap.getkitapyazar(), hedefkitap.getkitapdili(), hedefkitap.getYayinevi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimyili());
            }
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            Form1 admincikis = new Form1();
            admincikis.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapılıyor","Bilgilendirme...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
