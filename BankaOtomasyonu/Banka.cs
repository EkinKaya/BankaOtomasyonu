using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
   public class Banka : IBankaninOzellikleri, IRaporOzellikleri
    {
        public List<Personel> personeller = new List<Personel>();
        public List<BireyselMusteri> BireyselMusteriler = new List<BireyselMusteri>();
        public List<TicariMusteri> TicariMusteriler = new List<TicariMusteri>();
        public List<Rapor> BankaRaporListesi = new List<Rapor>();
        public decimal toplamPara { get; set; }

        Personel personel;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Rapor rapor1;


        public void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih)
        {

            if (musteriTipi == true)
            {
                bireyselMusteri = new BireyselMusteri(); //musteri tipi true ise bireysel müşteri sınıfından nesne üretip banka sınıfındaki bireysel musteriler listesine ekliyoruz

                this.bireyselMusteri.Ad = ad;
                this.bireyselMusteri.Soyad = soyad;
                this.bireyselMusteri.ID = ID;
                this.bireyselMusteri.Sifre = sifre;
                this.bireyselMusteri.KayitTarihi = tarih;
                this.bireyselMusteri.MusteriTipi = "Bireysel";

                BireyselMusteriler.Add(bireyselMusteri);
                
                MessageBox.Show("Bireysel Müşteri Başarıyla Eklendi.");
            }
            else
            {
                ticariMusteri = new TicariMusteri();

                ticariMusteri.Ad = ad;
                ticariMusteri.Soyad = soyad;
                ticariMusteri.ID = ID;
                ticariMusteri.Sifre = sifre;
                ticariMusteri.KayitTarihi = tarih;
                ticariMusteri.MusteriTipi = "Ticari";

                TicariMusteriler.Add(ticariMusteri);
                MessageBox.Show("Ticari Müşteri Başarıyla Eklendi.");
            }
        }

        public void PersonelEkle(string ad, string soyad, string ID, string sifre)
        {
            personel = new Personel(); //bu metot personel sınıfına yeni bir nesne oluşturup gerekli atamalar sonrası bankanın personel listesine bu personeli ekler

            this.personel.Ad = ad;
            this.personel.Soyad = soyad;
            this.personel.ID = ID;
            this.personel.Sifre = sifre;

            personeller.Add(personel);
            MessageBox.Show("Personel Başarıyla Eklendi.");
        }

        public void PersonelSil(string kullaniciAdi)  //kullanıcı adıyla personel listede aranır ve bulununca remove ile silinir
        {
            foreach (Personel personel1 in personeller.ToList())
            {
                if (kullaniciAdi == personel1.ID)
                {
                    personeller.Remove(personel1);
                    MessageBox.Show("Personel Silindi.");
                }
            }
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {
            rapor1 = new Rapor(); //bu metot rapor sınıfından yeni bir nesne üretip gerekli atamaları yapar ve banka sınıfındaki banka rapor listesine bu raporu ekler
            rapor1.rapor = rapor;
            rapor1.Tarih = tarih;
            BankaRaporListesi.Add(rapor1);
        }
    }
}
