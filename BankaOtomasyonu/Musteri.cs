using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public abstract class Musteri : Kisi, IMusteriOzellikleri
    {
        public DateTime KayitTarihi { get; set; }
        public string MusteriTipi { get; set; }
        public List<Hesap> MusterininHesaplari { get; set; }

        Hesap yeniHesap; //Yeni hesap açarken hesap nesnesi oluşturacağız.

        string rapor;
        DateTime tarih;
        public Musteri()
        {
            MusterininHesaplari = new List<Hesap>();
        }

        //IMusteriOzellikleri interface'inin metotlarını implamente etmemizi (bu sınıf içerisinde) istediği için, arabirime uygula dedik.
        public void HesabaParaYatir(Hesap buHesaba, decimal paraMiktari)
        {
            buHesaba.bakiye += paraMiktari;

            MessageBox.Show("Hesabınıza '" + paraMiktari + "' TL eklenmiştir. \n Mevcut bakiye '" + buHesaba.bakiye + "' TL");
            rapor = ("'" + paraMiktari + "' TL yatırıldı.");
            tarih = DateTime.Today;

            buHesaba.RaporEkle(rapor, tarih);

            if (buHesaba.EkBakiye < buHesaba.limit) //Ekbakiye borcu varsa
            {

                decimal borc = buHesaba.limit - buHesaba.EkBakiye;
                decimal odenenBorc = 0;

                for (decimal i = buHesaba.EkBakiye; buHesaba.EkBakiye < buHesaba.limit; i += 0.1m)//Ekbakiye borcu varsa para yatırırken otomatik olarak borç ödenir
                {
                    if (buHesaba.bakiye == 0.0m) 
                    {
                        break; 
                    }
                    
                    else
                    {

                        buHesaba.bakiye -= 0.1m;
                        odenenBorc += 0.1m;
                        buHesaba.EkBakiye += 0.1m;

                    }
                }
                MessageBox.Show("'" + borc + "' TL olan ek bakiye borcunuzun '" + odenenBorc + "' TL kadarı bakiyenizden tahsil edilmiştir. Kalan bakiyeniz: "+ buHesaba.limit);
                rapor = "'" + borc + "' TL olan ek bakiye borcunuzun '" + odenenBorc + "' TL kadarı bakiyenizden tahsil edilmiştir. Kalan bakiyeniz: "+ buHesaba.limit;
                tarih = DateTime.Today;
                buHesaba.RaporEkle(rapor, tarih);
            }
        }
        public void HesaptanParaCek(Hesap h, decimal paraMiktari)
        {
            if (h.EkBakiye != 0.0m && h.EkBakiye >= 0)
            {
                if (h.gunlukLimit != 0.0m && h.gunlukLimit >= 0.0m)
                {
                    if (h.gunlukLimit - paraMiktari != 0.0m && h.gunlukLimit - paraMiktari >= 0.0m) 
                    {
                        if (h.bakiye >= paraMiktari)
                        {
                            h.bakiye -= paraMiktari;
                            h.gunlukLimit -= paraMiktari;

                            MessageBox.Show("Hesabınızdan '" + paraMiktari + "' TL çekilmiştir. Kalan Bakiyeniz: " + h.limit);
                        }
                        else if (h.bakiye > 0)//Bakiye 0 dan büyükse (Örneğin bakiye 30tl müşteri 80 tl kalan 50tlyi ekbakiyeden çekeceği durumda burası çalışır.
                        {
                            if ((paraMiktari - h.bakiye) <= h.EkBakiye) //Çekilmek istenen bir kısmı bakiyede var ve diğer kısmı ek bakiyeden çekilecekse ek bakiye limiti yeterliyse
                            {
                                decimal bakiyedenCekilen, ekBakiyedenCekilen;

                                bakiyedenCekilen = h.bakiye; //Bakiyedeki miktar alınıyor
                                h.bakiye = 0; //Bakiye sıfırlanıyor
                                ekBakiyedenCekilen = paraMiktari - bakiyedenCekilen;//ekBakiyeden çekilecek para hesaplanıyor
                                h.EkBakiye -= ekBakiyedenCekilen;//Çekilen para ekBakiyeden eksiltiliyor.

                                h.gunlukLimit -= bakiyedenCekilen + ekBakiyedenCekilen; //Çekilen parayı günlük limitten düşüyoruz

                                MessageBox.Show("'" + bakiyedenCekilen + "' TL bakiyeden, '" + ekBakiyedenCekilen + "' TL Ek Bakiyeden çekilmiştir.Kalan Bakiyeniz: " + h.limit);

                                rapor = ("'" + bakiyedenCekilen + "' TL bakiyeden, '" + ekBakiyedenCekilen + "' Tl Ek Bakiyeden çekilmiştir.Kalan Bakiyeniz: " + h.limit);
                                tarih = DateTime.Today;
                                h.RaporEkle(rapor, tarih); //Hesap Özetine yapılan işlem ve tarihi gönderiliyor
                            }
                            else
                                MessageBox.Show("Ek bakiye limitiniz işlem için yeterli değildir. Kalan Bakiyeniz: " + h.limit);

                        }
                        else //Bakiyenin 0 olduğu ve çekilmek istenen miktarın ek bakiyeden çekileceği durumda çalışır.
                        {
                            if (h.EkBakiye >= paraMiktari)//Çekilmek istenen miktar için ek bakiye limiti yeterliyse 
                            {
                                h.EkBakiye -= paraMiktari;
                                h.gunlukLimit -= paraMiktari;//Çekilen parayı günlük limitten düşüyoruz

                                MessageBox.Show("'" + paraMiktari + "' TL ek bakiyeden çekilmiştir.");
                                rapor = "'" + paraMiktari + "' TL ek bakiyeden çekilmiştir.";
                                tarih = DateTime.Today;
                                h.RaporEkle(rapor, tarih); //Hesap Özetine yapılan işlem ve tarihi gönderiliyor
                            }
                            else
                                MessageBox.Show("Ek bakiye limitiniz işlem için yeterli değildir.");
                        }
                    }
                    else
                        MessageBox.Show("Çekmek istediğiniz miktar kalan günlük para çekme limitinizden fazla olamaz.");
                }
                else
                    MessageBox.Show("Günlük para çekme limitiniz dolmuştur.");
            }
            else //Belirlenen ek bakiyeden fazla para çekilmek istenirse
                MessageBox.Show("Ek Bakiye'den para çekme limitiniz dolmuştur.");

        }
        
        public void YeniHesapAc(int EkBakiye)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100, 1000);

            yeniHesap = new Hesap();
            yeniHesap.No = sayi;
            yeniHesap.bakiye = 0;
            yeniHesap.EkBakiye = EkBakiye; 
            yeniHesap.limit = EkBakiye;  
            yeniHesap.gunlukLimit = 750;
            MusterininHesaplari.Add(yeniHesap);

            MessageBox.Show("'"+ID+" Numarali müşteri için '"+sayi+"' numarali hesap '"+EkBakiye+"'ek bakiyesi ile açılmıştır");
        }

        public void HesabıSil(int hesapNo)
        {
            foreach (Hesap h in MusterininHesaplari.ToList())
            {
                if (hesapNo == h.No)
                {
                    if (h.bakiye == 0 && h.EkBakiye == h.limit) 
                    {
                        MusterininHesaplari.Remove(h);
                        MessageBox.Show("'" + hesapNo + "' numaralı hesap başarıyla silindi.");
                    }
                    else
                        MessageBox.Show("'" + hesapNo + "' numaralı hesap silinebilmesi için bakiyesi 0 TL ve ek bakiye borcu olmamalıdır. \n Mevcut Bakiye: '" + h.bakiye + "' TL \n Güncel borç: '" + (h.limit - h.EkBakiye + "' TL"));
                }
            }
        }

    }
}
