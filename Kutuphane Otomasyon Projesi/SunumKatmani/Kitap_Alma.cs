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
using isKatmani;
using VeriTabaniKatmani;

namespace SunumKatmani
{
    public partial class Kitap_Alma : Form
    {
        public Kitap_Alma()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void Kitap_Alma_Load(object sender, EventArgs e)//veri tabanında kayıtlı kitapları combo box'a yazdırmaiçin
                                                                //Takip tablosu ve kitaplar tablosuna veri girişi için    
        {
            List<string> kitaplar = new List<string>();
            kitap_goruntuleme goruntuleyici = new kitap_goruntuleme();
            kitaplar = goruntuleyici.kitapAlmaLoad();
            for(int i=0; i<kitaplar.Count; i++)
            {
                cBx_kitaplar.Items.Add(kitaplar[i]);
            }
        }
        private void bttn_alma_Click(object sender, EventArgs e)
        {
            string kitap_adi;

            kitap_goruntuleme kiralama = new kitap_goruntuleme();//kitaplar tablosu için
            kitap_adi = cBx_kitaplar.SelectedItem.ToString();

            string kitap_alan_no = txt_no.Text;
            string Kitap_Alım_Tarihi;
            bool kitaplikta_mi= false ;
            
            DateTime simdikiZaman = DateTime.Now;
            Kitap_Alım_Tarihi = simdikiZaman.ToString();

            bool sonuc;
            sonuc = kiralama.kitap_alma(kitap_adi, kitap_alan_no, Kitap_Alım_Tarihi,kitaplikta_mi);
            if(sonuc == false)
            {
                MessageBox.Show("HATALI İŞLEM GERÇEKLEŞTİRDİNİZ!!!");
            }
            else if(sonuc==true)
            {
                MessageBox.Show("Başarılı");
            }

            Takip_goruntuleme takip = new Takip_goruntuleme(); //Takip tablosu için
            DateTime teslimTarihi = dateTimePicker1.Value;
            TimeSpan tarihFark = teslimTarihi - simdikiZaman;
            int tarihfarki = tarihFark.Days + 1;
            int zamanKiyaslamaSonucu = DateTime.Compare(teslimTarihi, simdikiZaman); 
            double ogrenciCeza = tarihfarki * 1 - 1;
            string ceza = ogrenciCeza.ToString();
            bool teslim_edildi_mi = false;

            if (ogrenciCeza>0)
            {
                ogrenciCeza = 0;
                ceza = ogrenciCeza.ToString();

            }
            else if (ogrenciCeza<0)
            {
                ogrenciCeza = ogrenciCeza * (-1);
                ceza = ogrenciCeza.ToString();
            }
            takip.takipetme(kitap_alan_no, kitap_adi, Kitap_Alım_Tarihi, teslimTarihi.ToString(),teslim_edildi_mi,ceza);

           

            this.Close();
        }
        private void cBx_kitaplar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bttn_alma.Enabled = true;

        }
    }
}
