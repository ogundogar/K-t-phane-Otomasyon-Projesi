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
    public partial class Kitap_Ekleme_form : Form
    {
        public Kitap_Ekleme_form()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        kitap_listesi listekitap = new kitap_listesi();
        private void bttn_kaydet_Click(object sender, EventArgs e)
        {
            //kitaplar tablosuna dışarıdan alınan verileri girmek için
            try
            {
                bgl.baglan.Open();
                string kitapAdi = txt_kitapadi.Text;
                string yazarAdi = txt_yazaradi.Text;
                string yayinEvi = txt_yayınevi.Text;
                bool kitaplikta_mi = true;
                OleDbCommand komut = new OleDbCommand("insert into Kitaplar (Kitap_Adı,Yazar_Adı,Yayınevi,kitaplikta_mi)values(@kitapAdi,@yazarAdi,@yayinEvi,@kitaplikta_mi)", bgl.baglan);
                komut.Parameters.AddWithValue("@kitapAdi", kitapAdi);
                komut.Parameters.AddWithValue("@yazarAdi", yazarAdi);
                komut.Parameters.AddWithValue("@yayinEvi", yayinEvi);
                komut.Parameters.AddWithValue("@kitaplikta_mi", kitaplikta_mi);
                komut.ExecuteNonQuery();
                bgl.baglan.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("hata oluştu");
            }
            listekitap.Show();
            this.Close();

        }

    }
}
