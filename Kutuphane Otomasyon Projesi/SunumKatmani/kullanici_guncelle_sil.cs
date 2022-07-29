using isKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriTabaniKatmani;

namespace SunumKatmani
{
    public partial class kullanici_guncelle_sil : Form
    {
        public kullanici_guncelle_sil()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        OleDbCommand komut = new OleDbCommand();
        private void bttn_Sil_Click(object sender, EventArgs e)//kayıt_kişiler_görüntüle katmanı ile silme işlemi yapmak
        {

            int kullanici_ID = Convert.ToInt32(txt_silme.Text);
            bgl.baglan.Open();
            komut.Connection = bgl.baglan;
            kayitli_kisiler_goruntuleme silme = new kayitli_kisiler_goruntuleme();
            silme.kullaniciSilme(kullanici_ID);
            bgl.baglan.Close();

            kayitli_kisiler_goruntuleme kayıtkisiler = new kayitli_kisiler_goruntuleme();
            dGv_listele.DataSource = kayıtkisiler.kayitli_Kisiler_Getir();
        }

        private void kullanici_guncelle_sil_Load(object sender, EventArgs e)//kayıt_kişiler_görüntüle katmanı ile görüntüleme yapmak için
        {

            kayitli_kisiler_goruntuleme kayıtkisiler = new kayitli_kisiler_goruntuleme();
            dGv_listele.DataSource = kayıtkisiler.kayitli_Kisiler_Getir();
        }

        private void bttn_guncelle_Click(object sender, EventArgs e)//kayıt_kişiler_görüntüle katmanı ile güncellemek için
        {
            kayitli_kisiler_goruntuleme guncelleyici = new kayitli_kisiler_goruntuleme();
            string kullanici_Adi = txt_adi.Text;
            string kullanici_Soyadi = txt_soyadi.Text;
            string kullanici_NO = txt_No.Text;
            int kullanici_ID = Convert.ToInt32(txt_ID.Text);
            guncelleyici.kullanicGuncelle(kullanici_ID, kullanici_Adi, kullanici_Soyadi, kullanici_NO);
            dGv_listele.DataSource = guncelleyici.kayitli_Kisiler_Getir();

        }

        private void dGv_listele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
