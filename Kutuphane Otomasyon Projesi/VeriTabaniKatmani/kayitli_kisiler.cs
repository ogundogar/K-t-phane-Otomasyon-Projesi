using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniKatmani
{
    //veri tabanındaki kayitli_kisiler tablosundaki verileri temsili olarak oluşturduğum proplar(veri tabanı ile ilgili işlemleri buradan halledeceğim)

    public class kayitli_kisiler
    {
        public int kullanici_ID { get; set; }
        public string kullanici_Adi { get; set; }
        public string kullanici_Soyadi { get; set; }
        public string kullanici_NO { get; set; }

        public kayitli_kisiler(int kullanici_ID, string kullanici_Adi, string kullanici_Soyadi, string kullanici_NO)
        {
            this.kullanici_ID = kullanici_ID;
            this.kullanici_Adi = kullanici_Adi;
            this.kullanici_Soyadi = kullanici_Soyadi;
            this.kullanici_NO = kullanici_NO;
        }
    }
}
