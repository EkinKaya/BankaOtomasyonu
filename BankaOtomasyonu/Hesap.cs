using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Hesap:IRaporOzellikleri
    {
        public int No { get; set; } //hesapno
        public decimal bakiye { get; set; }
        public decimal gunlukLimit { get; set;} //günlük para çekme limiti
        public decimal EkBakiye { get; set; }
        public decimal limit { get; set; }
        //hesaba ait işlemleri(havale gibi) listelemek için bunları rapor listesinde tutmamız gerek
        public List<Rapor> RaporListesi;
        //yani her bir yeni işlemde rapor sınıfından yeni bir nesne oluşturacağız, rapor ve tarih değişkenlerini doldurduktan sonra hesap sınıfındaki raporlistesine eklenecek sonra dataviewe
        Rapor r; //rapor değişkeni tanımladık rapor eklerken r=new rapor() diyeceğiz

        public Hesap()
        {
            RaporListesi=new List<Rapor>();
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {
            r=new Rapor();
            //o hesaba ait raporekle metoduna gelen rapor metnini buradaki r.rapor a ata
            this.r.rapor= rapor;
            this.r.Tarih = tarih;

            //oluşturulan rapor nesnesi bu hesaba ait rapor listesine ekleyeceğiz
            RaporListesi.Add(r);
        }
    }
}
