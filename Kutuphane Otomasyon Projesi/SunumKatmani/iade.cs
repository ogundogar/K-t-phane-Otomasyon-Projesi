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
    public partial class iade : Form
    {
        public iade()
        {
            InitializeComponent();
        }

        private void bttn_iade_Click(object sender, EventArgs e)//iade butonuna basarak takip tablosunu ve kitaplar tablosundaki verileri değiştiriyor
                                                                // teslimTarihi, teslimEdildiMi,kitaplıtami,kitap_alan_okul_no(veri tabanına boş olarak dönmesi için)
        {                                                       //kitap_adı ve kullanıcı no ile veri tabanındaki tablolardaki satırları belirliyoruz. 
            string kullanici_no=textBox1.Text;
            string kitap_adi = comboBox1.SelectedItem.ToString();
            
            DateTime simdikiZaman = DateTime.Now;
            string teslimTarihi = simdikiZaman.ToString();
            bool teslimEdildiMi = true;



            iade_islemleri iadeİslemleri =new iade_islemleri();
            iadeİslemleri.kitaplıkta_mi_guncelleme(kitap_adi,true," ");
            iadeİslemleri.kitapiade(kullanici_no, kitap_adi, teslimTarihi, teslimEdildiMi);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//kitap göster butonona basarak kullanıcı no yardımı ile combo box'a aldığı kitapları alma
        {
            Takip_goruntuleme takip_Goruntuleme = new Takip_goruntuleme();
            List<Takip> takipListesi = new List<Takip>();
            takipListesi = takip_Goruntuleme.takipGetir2(textBox1.Text);

            for (int i = 0; i < takipListesi.Count; i++)
            {
                if(takipListesi[i].teslim_edildi_mi == false)
                {
                    comboBox1.Items.Add(takipListesi[i].kitap_adi);
                }
            }
            button1.Enabled = false;
        }
    }
}
