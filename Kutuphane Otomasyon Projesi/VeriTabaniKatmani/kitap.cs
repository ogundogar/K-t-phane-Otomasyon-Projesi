using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniKatmani
{
    public class kitap
    {
        //veri tabanındaki kitap tablosundaki verileri temsili olarak oluşturduğum proplar(veri tabanı ile ilgili işlemleri buradan halledeceğim)
        public int kitap_ID { get; set; }
        public string Kitap_Adı { get; set; }
        public string Yazar_Adı { get; set; }
        public string Yayınevi { get; set; }
        public bool kitaplikta_mi { get; set; }
        public string kitabi_alan_okul_no { get; set; }
        public string Kitap_Alım_Tarihi { get; set; }
        public kitap(int kitapID,string kitapAdi,string yazarAdi,string yayinEvi,bool kitapliktaMi,string kitabiAlanOkulNo,string Kitap_Alım_Tarihi)
        {
            this.kitap_ID = kitapID;
            this.Kitap_Adı = kitapAdi;
            this.Yazar_Adı = yazarAdi;
            this.Yayınevi = yayinEvi;
            this.kitaplikta_mi = kitapliktaMi;
            this.kitabi_alan_okul_no = kitabiAlanOkulNo;
            this.Kitap_Alım_Tarihi = Kitap_Alım_Tarihi;

        }

      

    }
}
