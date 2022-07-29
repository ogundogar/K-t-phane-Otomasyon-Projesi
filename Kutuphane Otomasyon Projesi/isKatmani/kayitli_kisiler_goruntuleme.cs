using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniKatmani;

namespace isKatmani
{
    public class kayitli_kisiler_goruntuleme
    {
        baglanti bgl = new baglanti();
        //kayıtlı kişileri görüntülemek için kayitli_kisiler_getir metotunu oluşturdum
        //kayıtlı kişileri güncellemek için kullanicGuncelle metotu oluşturdum
        //kayıtlı kişileri silmek içinde kullaniciSilme metotunu oluturdum
        public List<kayitli_kisiler> kayitli_Kisiler_Getir()//Görüntüleme
        {
            List<kayitli_kisiler> kayitliKisiler = new List<kayitli_kisiler>();
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kayitli_Kisiler", bgl.baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                kayitli_kisiler kk = new kayitli_kisiler(Convert.ToInt32(okuyucu["kullanici_ID"]),
                    okuyucu["kullanici_Adi"].ToString(),
                    okuyucu["kullanici_Soyadi"].ToString(),
                    okuyucu["kullanici_NO"].ToString());
        kayitliKisiler.Add(kk);
            };
    bgl.baglan.Close();
            return kayitliKisiler;
        }

        public void kullanicGuncelle(int kullanici_ID, string kullanici_Adi, string kullanici_Soyadi, string kullanici_NO)//kullanici güncelleme
        {

            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kayitli_Kisiler SET kullanici_Adi = @kullanici_Adi,kullanici_Soyadi = @kullanici_Soyadi, kullanici_NO =@kullanici_NO WHERE kullanici_ID = @kullanici_ID", bgl.baglan);
            komut.Parameters.AddWithValue("@kullanici_Adi", kullanici_Adi);
            komut.Parameters.AddWithValue("@kullanici_Soyadi", kullanici_Soyadi);
            komut.Parameters.AddWithValue("@kullanici_NO", kullanici_NO);
            komut.Parameters.AddWithValue("@kullanici_ID", kullanici_ID);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();
        }

        public void kullaniciSilme(int kitapID)//kullanici silme 
        {

            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("DELETE * FROM Kayitli_Kisiler WHERE kullanici_ID = @kullanici_ID", bgl.baglan);
            komut.Parameters.AddWithValue("@kullanici_ID", kitapID);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();
        }

    }
}
