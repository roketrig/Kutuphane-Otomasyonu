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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapılıyor", "Bilgilendirme...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView3.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getYayinevi(), kitap.gettur(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(txt_kitapId.Text);
            Kitap hedefKitap = null;
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid() == kitapId)
                {
                    hedefKitap = kitap;
                }
            }
            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add(hedefKitap.getkitapid(), hedefKitap.getkitapisim(), hedefKitap.getkitapyazar(), hedefKitap.getkitapdili(), hedefKitap.getYayinevi(), hedefKitap.gettur(), hedefKitap.getsayfasayisi(), hedefKitap.getbasimyili());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView3.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getYayinevi(), kitap.gettur(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }
        }
    }
}
