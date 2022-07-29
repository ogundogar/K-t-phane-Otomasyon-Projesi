using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniKatmani;

namespace isKatmani
{
   public class kitap_goruntuleme
    {

        baglanti bgl = new baglanti();
        // kitap görüntülemek için kitaplariGetir metotu oluşturdum
        //kitapları güncelleme için kitapGuncelle metotu
        //kitapları silmek için kitapSilme metotu
        //kitap aldıkta sonra Kayitli_Kisiler ve Kitaplar bilgilerini güncelleme için kitap_alma metotu
        //kitapları sunum katmanındaki Kitap_Alma formunda Combobox(aynı zamanda kitap arama yapabilmek için) içine eklemek için kitapAlmaLoad metotu oluşturdum
        public List<kitap> kitaplariGetir()//Görüntüleme
        {
            List<kitap> kitaplar = new List<kitap>();
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar", bgl.baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                kitap kitap = new kitap
                    (
                    Convert.ToInt32(okuyucu["kitap_ID"]),
                    okuyucu["Kitap_Adı"].ToString(),
                    okuyucu["Yazar_Adı"].ToString(),
                    okuyucu["Yayınevi"].ToString(),
                    Convert.ToBoolean(okuyucu["kitaplikta_mi"]),
                    okuyucu["kitabi_alan_okul_no"].ToString(),
                    okuyucu["Kitap_Alım_Tarihi"].ToString()
                    );
                kitaplar.Add(kitap);
            };
            bgl.baglan.Close();
            return kitaplar;
        }
        public void kitapGuncelle(int kitapID,string kitapAdi,string yazarAdi,string yayinEvi)//Kitaplar güncelleme
        {
            
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitaplar SET Kitap_Adı = @kitapAdi,Yazar_Adı = @yazarAdi, Yayınevi =@yayinEvi WHERE kitap_ID = @kitapID",bgl.baglan);
            komut.Parameters.AddWithValue("@kitapAdi", kitapAdi);
            komut.Parameters.AddWithValue("@yazarAdi",yazarAdi);
            komut.Parameters.AddWithValue("@yayinEvi",yayinEvi);
            komut.Parameters.AddWithValue("@kitapID",kitapID);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();
        }

        public void kitapSilme(int kitapID)//kitap silme işlemi için
        {

            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("DELETE * FROM kitaplar WHERE kitap_ID = @kitap_ID", bgl.baglan);
            komut.Parameters.AddWithValue("@kitapID", kitapID);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();
        }


        public bool kitap_alma(string kitapAdi,string kitabi_alan_okul_no,string Kitap_Alım_Tarihi,bool kitaplikta_mi)//Kitaplar alma işlemi için
        {
            bool sonuc = false;

            bgl.baglan.Open();
            //burada kullanıcı no'nu konturol ediyorum
            OleDbCommand onKosulKomutu = new OleDbCommand("SELECT * FROM Kayitli_Kisiler WHERE kullanici_NO = @okulNo", bgl.baglan);
            onKosulKomutu.Parameters.AddWithValue("@okulNo", kitabi_alan_okul_no);
            OleDbDataReader okuyucu = onKosulKomutu.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (okuyucu.Read())
            {   //burada da kullanıcı no ile kitabi_alan_okul_no aynı ise kitap alma açılır
                if (okuyucu["kullanici_NO"].ToString() == kitabi_alan_okul_no)
                {
                    OleDbCommand komut = new OleDbCommand("UPDATE Kitaplar SET kitabi_alan_okul_no = @kitabi_alan_okul_no,Kitap_Alım_Tarihi = @Kitap_Alım_Tarihi,kitaplikta_mi = @kitaplikta_mi WHERE Kitap_Adı = @kitapAdi", bgl.baglan);
                    komut.Parameters.AddWithValue("@kitabi_alan_okul_no", kitabi_alan_okul_no);
                    komut.Parameters.AddWithValue("@Kitap_Alım_Tarihi", Kitap_Alım_Tarihi);
                    komut.Parameters.AddWithValue("@kitaplikta_mi", kitaplikta_mi);
                    komut.Parameters.AddWithValue("@kitapAdi", kitapAdi);
                    komut.ExecuteNonQuery();
                    sonuc = true;
                }
            }
            bgl.baglan.Close();
            return sonuc;
        }

        public List<string> kitapAlmaLoad()//Kitap adını combobox içine yazdırmak için
        {
            List<string> kitaplar = new List<string>();
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar", bgl.baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while(okuyucu.Read())
            {
                kitaplar.Add(okuyucu["kitap_Adı"].ToString());
            }
            bgl.baglan.Close();
            return kitaplar;



        }

    }
    
}
