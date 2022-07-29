using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using isKatmani;
using VeriTabaniKatmani;

namespace SunumKatmani
{
    public partial class kitap_listesi : Form
    {
        public kitap_listesi()
        {
            InitializeComponent();
        }
        kitap_goruntuleme kg = new kitap_goruntuleme();
        private void kitap_listesi_Load(object sender, EventArgs e)//iş katmanındaki kitap_goruntule ile bağlantı kurup ekrana yazdırmak için
        {

            kitap_goruntuleme kitaplisteleme = new kitap_goruntuleme();
            kitap_listele_dGV.DataSource = kitaplisteleme.kitaplariGetir();
        }

        private void bttn_kitap_ekleme_Click(object sender, EventArgs e)//kitap_ekle formunu görüntülemek için
        {
            Kitap_Ekleme_form ekle = new Kitap_Ekleme_form();
            ekle.Show();
            this.Close();
        }

        private void bttn_kitap_gunc_silm_Click(object sender, EventArgs e)//kitap_silme_guncelleme formunu görüntülemek için
        {
            kitap_silme_guncelleme guncelle_sil = new kitap_silme_guncelleme();
            guncelle_sil.Show();
            this.Close();
            
        }
    }
}
