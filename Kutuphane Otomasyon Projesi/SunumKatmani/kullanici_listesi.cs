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

namespace SunumKatmani
{
    public partial class kullanici_listesi : Form
    {
        public kullanici_listesi()
        {
            InitializeComponent();
        }

        private void kullanici_listesi_Load(object sender, EventArgs e)//kayıt_kişiler_görüntüle katmaını ile görüntüleme yapmak için
        {
            kayitli_kisiler_goruntuleme kayıtkisiler = new kayitli_kisiler_goruntuleme();
            dGv_kullanici_liste.DataSource = kayıtkisiler.kayitli_Kisiler_Getir();
        }

        private void bttn_kullanici_ekle_Click(object sender, EventArgs e)//kullanınıc ekle formunu göstermek için
        {
            Kullanici_ekleme goruntule = new Kullanici_ekleme();
            goruntule.Show();
            this.Close();
        }

        private void bttn_kullanci_sil_guncelle_Click(object sender, EventArgs e)//kullanıcı sil ve güncelle formunu görüntülemek için
        {
            kullanici_guncelle_sil goruntule = new kullanici_guncelle_sil();
            goruntule.Show();
            this.Close();
        }

        private void bttn_takip_Click(object sender, EventArgs e)//kitap takip formunu görüntülemek için
        {
            Kitap_Takip kt = new Kitap_Takip();
            kt.Show();
        }
    }
}
