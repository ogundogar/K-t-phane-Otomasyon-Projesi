using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniKatmani;

namespace isKatmani
{
   public class Takip_goruntuleme
    {
        baglanti bgl = new baglanti();
        //Veri tabanındaki Takip tablosundaki verileri görüntüleme
        //Takip kullanici_no ile verileri çekmek için 
        //Takip tablosundaki yapılan işlemleri kaydetmek için
        public List<Takip> takipGetir()//görüntüleme
        {
            List<Takip> takipkitap = new List<Takip>();
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Takip", bgl.baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                Takip kitaptakip = new Takip( okuyucu["kullanici_no"].ToString(),
                    okuyucu["kitap_adi"].ToString(),
                    okuyucu["alim_tarihi"].ToString(),
                    okuyucu["teslim_tarihi"].ToString(),
                    Convert.ToBoolean(okuyucu["teslim_edildi_mi"]),
                    okuyucu["ceza"].ToString()
                    );
                takipkitap.Add(kitaptakip);
            };
            bgl.baglan.Close();
            return takipkitap;
        }
        public List<Takip> takipGetir2( string kosul)//kullanıcı no ile satır çekme
        {
            List<Takip> takipkitap = new List<Takip>();
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Takip WHERE kullanici_no = @kitapAdi", bgl.baglan);
            komut.Parameters.AddWithValue("@kitapAdi", kosul);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                Takip kitaptakip = new Takip(okuyucu["kullanici_no"].ToString(),
                    okuyucu["kitap_adi"].ToString(),
                    okuyucu["alim_tarihi"].ToString(),
                    okuyucu["teslim_tarihi"].ToString(),
                    Convert.ToBoolean(okuyucu["teslim_edildi_mi"]),
                    okuyucu["ceza"].ToString()
                    );
                takipkitap.Add(kitaptakip);
            };
            bgl.baglan.Close();
            return takipkitap;
        }
        public void takipetme(string kullanici_no, string kitap_adi, string alim_tarihi, string teslim_tarihi,bool teslim_edildi_mi, string ceza)//Tabloya kaydetmek için
        {
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("insert into Takip (kullanici_no,kitap_adi,alim_tarihi,teslim_tarihi,teslim_edildi_mi,ceza)values(@kullanici_no,@kitap_adi,@alim_tarihi,@teslim_tarihi,@teslim_edildi_mi,@ceza)", bgl.baglan);
            komut.Parameters.AddWithValue("@kullanici_no", kullanici_no);
            komut.Parameters.AddWithValue("@kitap_adi", kitap_adi);
            komut.Parameters.AddWithValue("@alim_tarihi", alim_tarihi);
            komut.Parameters.AddWithValue("@teslim_tarihi", teslim_tarihi);
            komut.Parameters.AddWithValue("@teslim_edildi_mi", teslim_edildi_mi);
            komut.Parameters.AddWithValue("@ceza", ceza);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();

        }
    }
}
