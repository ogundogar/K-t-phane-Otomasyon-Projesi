using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunumKatmani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kitap_listele_bttn_Click(object sender, EventArgs e)
        {
            //Sunum Katmanındaki kitaplar_listesini,Kitap_Ekleme ve Kitap_silme_guncelleme işlemini gösteren button
            kitap_listesi goruntule = new kitap_listesi();
            goruntule.Show();
            
        }

        private void bttn_kullanici_Click(object sender, EventArgs e)
        {
            //Sunum Katmanındaki kullanici_listele,Kullanıcı_Ekleme,kullanıcı_guncelleme_silme ve Kitap_Takip işlemini gösteren button
            kullanici_listesi goruntule = new kullanici_listesi();
            goruntule.Show();
        }

        private void bttn_alma_Click(object sender, EventArgs e)
        {
            //Sunum Katmanındaki kitap_Alma işlemini gösteren button
            Kitap_Alma goruntule = new Kitap_Alma();
            goruntule.Show();
        }

        private void bttn_iade_Click(object sender, EventArgs e)
        { 
            //Sunum Katmanındaki iade işlemini gösteren button
            iade goruntule = new iade();
            goruntule.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zedgrarp eklentisinden gelen grafiğini gösterir.
            Grafik grafik = new Grafik();
            grafik.Show();
        }
    }
}
