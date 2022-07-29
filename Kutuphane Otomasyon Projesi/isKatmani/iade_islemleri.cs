using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniKatmani;

namespace isKatmani
{
    //kitaplar veri tabanındaki verileri değiştirmek için kitaplıkta_mi_guncelleme metotunu oluşturdum
    //takip katmanındaki verileri değiştirmek için kitapiade metotunu oluşturdum
    public class iade_islemleri
    {
        baglanti bgl = new baglanti();
        public void kitaplıkta_mi_guncelleme(string kitapAdi,bool kitaplikta_mi, string kitabi_alan_okul_no)//Kitaplar veri tabanındaki "kitaplikta_mi" verisini değiştirmek için
        {
            
            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitaplar SET kitaplikta_mi =@kitaplikta_mi,kitabi_alan_okul_no=@kitabi_alan_okul_no WHERE Kitap_Adı = @kitapAdi", bgl.baglan);
            komut.Parameters.AddWithValue("@kitaplikta_mi", kitaplikta_mi);
            komut.Parameters.AddWithValue("@kitabi_alan_okul_no", kitabi_alan_okul_no);
            komut.Parameters.AddWithValue("@kitapAdi", kitapAdi);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();
        }
        public void kitapiade(string kullanici_no, string kitap_adi,string teslim_tarihi, bool teslim_edildi_mi)//iade durumunu değiştirmek için
        {

            bgl.baglan.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Takip SET kitap_adi = @kitap_adi, teslim_tarihi= @teslim_tarihi, teslim_edildi_mi= @teslim_edildi_mi WHERE kullanici_no = @kullanici_no", bgl.baglan);
            komut.Parameters.AddWithValue("@kitap_adi", kitap_adi);
            komut.Parameters.AddWithValue("@teslim_tarihi", teslim_tarihi);
            komut.Parameters.AddWithValue("@teslim_edildi_mi", teslim_edildi_mi);
            komut.Parameters.AddWithValue("@kullanici_no", kullanici_no);
            komut.ExecuteNonQuery();
            bgl.baglan.Close();
        }
    }
}
