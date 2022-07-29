using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniKatmani
{
    public class Takip
    {
        //veri tabanındaki Takip tablosundaki verileri temsili olarak oluşturduğum proplar (veri tabanı ile ilgili işlemleri buradan halledeceğim)
        //kitap takip ve kullanıcı takip işlemlerini bir tabloda halletmek için
        public string kullanici_no { get; set; }
        public string kitap_adi { get; set; }
        public string alim_tarihi { get; set; }
        public string teslim_tarihi { get; set; }
        public bool teslim_edildi_mi { get; set; }
        public string ceza { get; set; }

         
        public Takip( string kullanici_no, string kitap_adi, string alim_tarihi, string teslim_tarihi, bool teslim_edildi_mi, string ceza)
        {
            this.kullanici_no = kullanici_no;
            this.kitap_adi = kitap_adi;
            this.alim_tarihi = alim_tarihi;
            this.teslim_tarihi = teslim_tarihi;
            this.teslim_edildi_mi = teslim_edildi_mi;
            this.ceza = ceza;
        }

    }
}
