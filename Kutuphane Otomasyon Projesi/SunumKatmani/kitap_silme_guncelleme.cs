using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriTabaniKatmani;
using isKatmani;
using System.Data.OleDb;

namespace SunumKatmani
{
    public partial class kitap_silme_guncelleme : Form
    {
        public kitap_silme_guncelleme()
        {
            InitializeComponent();
        }
        OleDbCommand komut = new OleDbCommand();

        baglanti bgl = new baglanti();
        
        private void bttn_Sil_Click(object sender, EventArgs e)//kitapları ıd ile silmek için
        {
            int kitap_ID = Convert.ToInt32(txt_silme.Text);
            bgl.baglan.Open();
            komut.Connection = bgl.baglan;
            kitap_goruntuleme silme = new kitap_goruntuleme();
            silme.kitapSilme(kitap_ID);
            bgl.baglan.Close();

            kitap_goruntuleme kitaplisteleme = new kitap_goruntuleme();
            dataGridView1.DataSource = kitaplisteleme.kitaplariGetir();

        }

        private void kitap_silme_guncelleme_Load(object sender, EventArgs e)//kitapları görüntülemek için
        {
            kitap_goruntuleme guncelleyici = new kitap_goruntuleme();
            dataGridView1.DataSource = guncelleyici.kitaplariGetir();
        }

        private void bttn_guncelle_Click(object sender, EventArgs e)//kitapları güncellemek için kitap id ile
        {
            
           kitap_goruntuleme  guncelleyici = new kitap_goruntuleme();
            string ad = txt_kitapadi.Text;
            string yazar = txt_yazaradi.Text;
            string yayinevi = txt_yayınevi.Text;
            int id = Convert.ToInt32(txt_ID.Text);
            guncelleyici.kitapGuncelle(id, ad, yazar, yayinevi);
            dataGridView1.DataSource = guncelleyici.kitaplariGetir();
        }
    }
}
