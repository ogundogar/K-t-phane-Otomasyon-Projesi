using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniKatmani
{
    //baglamti sınıfını önce entity framework kullanmak için kurmuştum ama kullanamadım bende boş kalmasın diye veri tabanı baglantı adresini bu katmanda
    //tanımladım ve diğer katmanlara buradan çağırdım..
    public class baglanti
    {
        public OleDbConnection baglan = new OleDbConnection(@" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=veritabani.mdb ");
      
    }
}
