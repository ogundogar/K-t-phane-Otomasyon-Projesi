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
    public partial class Kullanici_ekleme : Form
    {
        public Kullanici_ekleme()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void bttn_kaydet_Click(object sender, EventArgs e)//kayitli_kişileri_goruntule ile kayıtlı kişiler tablosuna eklemek için
        {

            try
            {
                bgl.baglan.Open();
                string kullanici_adi = txt_adi.Text;
                string kullanici_soyadi = txt_soyad.Text;
                string kullanici_No = txt_no.Text;
                OleDbCommand komut = new OleDbCommand("insert into Kayitli_Kisiler (kullanici_Adi,kullanici_Soyadi,kullanici_NO)values(@kullanici_Adi,@kullanici_Soyadi,@kullanici_NO)", bgl.baglan);
                komut.Parameters.AddWithValue("@kullanici_Adi", kullanici_adi);
                komut.Parameters.AddWithValue("@yazarAdi", kullanici_soyadi);
                komut.Parameters.AddWithValue("@kullanici_Soyadi", kullanici_No);
                komut.ExecuteNonQuery();
                bgl.baglan.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("hata oluştu");
            }
            kullanici_listesi goruntule = new kullanici_listesi();
            goruntule.Show();
            this.Close();

        }
    }
}
