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
    public partial class Kitap_Takip : Form
    {
        public Kitap_Takip()
        {
            InitializeComponent();
        }

        private void Kitap_Takip_Load(object sender, EventArgs e)//Takip tablosunu görüntülemek için
        {

            Takip_goruntuleme kitaplisteleme = new Takip_goruntuleme();
            dataGridView1.DataSource = kitaplisteleme.takipGetir();

        }
            baglanti bgl = new baglanti();
        private void bttn_tmm_Click(object sender, EventArgs e)//tamam butonuna basınca kullanıcı no ile kitap takip yapıyorum.
        {
            string kullaniciNo = txt_k_NO.Text;
            List<Takip> takipListe = new List<Takip>();
            Takip_goruntuleme kitaplisteleme = new Takip_goruntuleme();
            takipListe = kitaplisteleme.takipGetir2(kullaniciNo);
            dataGridView1.DataSource = takipListe;

           


            for (int i = 0; i < takipListe.Count; i++)
            {
                DateTime sonTeslimTarihi = Convert.ToDateTime(takipListe[i].teslim_tarihi);
                DateTime alimTarihi = Convert.ToDateTime(takipListe[i].alim_tarihi);
                TimeSpan fark = sonTeslimTarihi - alimTarihi;
                int asilFark = fark.Days;

                for (int j = 0; j < 5; j++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == true)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                    }
                    if(Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == false && asilFark<=3 && asilFark>=0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                    if(Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == false && asilFark<0 )
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                }
            }

        }
    }
}
