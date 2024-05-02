using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class MusteriFormu : Form
    {

        bool bireyselMi;
        public MusteriFormu(Banka banka, BireyselMusteri BireyselM)//Bu form açıldığında giriş yapan müşteri bireysel ise bu constructor çalışır.
        {
            InitializeComponent();
            this.banka = banka;
            this.bireyselMusteri = BireyselM;
            bireyselMi = true;
        }
        public MusteriFormu(Banka banka, TicariMusteri TicariM)
        {
            InitializeComponent();
            this.banka = banka;
            this.ticariMusteri = TicariM;
            bireyselMi = false;
        }

      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        Banka banka;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
       
        private void btnParaCek_Click(object sender, EventArgs e)
        {
        
            int hesapNo = Convert.ToInt32(txtbxParaCekmeHesapNumarasi.Text);
            decimal miktar = Convert.ToDecimal(txtbxParaCekmekMiktari.Text);

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                foreach (Hesap hesapBireysel in m.MusterininHesaplari)
                {
                    if (hesapNo == hesapBireysel.No)
                        m.HesaptanParaCek(hesapBireysel, miktar);
                }

            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {

                foreach (Hesap hesapTicari in m.MusterininHesaplari)
                {
                    if (hesapNo == hesapTicari.No)
                        m.HesaptanParaCek(hesapTicari, miktar);
                }

            }
        }

        private void btnHesaplarimiListele_Click(object sender, EventArgs e)
        {
            
            dtGrdVwHesaplarim.DataSource = null;

           
                if (bireyselMi == true)

                    dtGrdVwHesaplarim.DataSource = bireyselMusteri.MusterininHesaplari;
            
                else
              
                    dtGrdVwHesaplarim.DataSource = ticariMusteri.MusterininHesaplari;
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtbxParaYatirHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txtbxParaYatirParaMiktari.Text);

            foreach (BireyselMusteri m in banka.BireyselMusteriler)
            {
                foreach (Hesap h in m.MusterininHesaplari)
                {
                    if (hesapNo == h.No)
                        m.HesabaParaYatir(h, miktar);
                }

            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                foreach (Hesap h in m.MusterininHesaplari)
                {
                    if (hesapNo == h.No)
                        m.HesabaParaYatir(h, miktar);
                }

            }
        }

        private void btnHOzetListele_Click(object sender, EventArgs e)
        {
            int hesapNo = 0;
            if (txtbxHesapNoHOzet.Text != "")//Hesap Özeti Listeleme TextViewi boş bırakılırsa hata vermemesi için
            {
                hesapNo = Convert.ToInt32(txtbxHesapNoHOzet.Text);

                DateTime timeBaslangic = dateTimeBaslangic.Value;
                DateTime timeBitis = dateTimeBitis.Value;

                int BaslangicGun = timeBaslangic.Day;
                int BitisGun = timeBitis.Day;

                List<Rapor> GosterilecekRapor = new List<Rapor>();

                foreach (BireyselMusteri m in banka.BireyselMusteriler)
                {
                    foreach (Hesap h in m.MusterininHesaplari)
                    {
                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                TimeSpan t = timeBitis - r.Tarih;//Seçilen bitiş tarihi ile işlem tarihi arasındaki farkı alıyoruz.
                                int baslangicDegeri = t.Days; //Farkı güne çeviriyoruz.
                                TimeSpan t2 = r.Tarih - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)//Eğer ki farklar - değer değilse yani belirtilen aralık arasındaysa 
                                {
                                    GosterilecekRapor.Add(r);
                                }
                            }
                        }
                    }
                }
                foreach (TicariMusteri m in banka.TicariMusteriler)
                {

                    foreach (Hesap h in m.MusterininHesaplari)
                    {
                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                TimeSpan t = timeBitis - r.Tarih;
                                int baslangicDegeri = t.Days;
                                TimeSpan t2 = r.Tarih - timeBaslangic;
                                int bitisDegeri = t2.Days;
                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)
                                {
                                    GosterilecekRapor.Add(r);
                                }
                            }
                        }
                    }

                }
             dtGrdVwHesapOzeti.DataSource = GosterilecekRapor;
            }
            else
                MessageBox.Show("Lütfen hesap numarası giriniz.");
        }

        private void btnHavaleEt_Click(object sender, EventArgs e)
        {
            int kaynakNo = Convert.ToInt32(txtbxHavaleGonderenHesapNo.Text);
            int hedefNo = Convert.ToInt32(txtbxHavaleGonderilecekHesapNo.Text);
            int miktar = Convert.ToInt32(txtbxHavaleMiktar.Text);

            decimal bankaPayi = 0.0m, hedefPayi = 0.0m;
            decimal islemOrani = 0.0m;

            Hesap kaynakHesap = null, hedefHesap = null;
            Musteri kaynakMusteri = null;
            bool kaynakDurum = false, hedefDurum = false, kaynakHesapTuru = false;

            foreach (BireyselMusteri m in banka.BireyselMusteriler) //kaynak hesap bireysel müşteri iste
            {
                foreach (Hesap h in m.MusterininHesaplari)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;
                        kaynakHesapTuru = true;
                    }
                    if (hedefNo == h.No)
                    {
                        hedefHesap = h;
                        hedefDurum = true;
                    }
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)
            {
                foreach (Hesap h in m.MusterininHesaplari)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;


                    }
                    if (hedefNo == h.No)
                    {
                        hedefHesap = h;
                       
                        hedefDurum = true;
                    }
                }
            }


            if (kaynakDurum == true && hedefDurum == true)//Kaynak ve Hedef hesap numaraları bulunduysa
            {
                if (kaynakHesap.bakiye >= miktar)
                {
                    if (kaynakHesapTuru == true)
                        islemOrani = 2.0m;

                    kaynakHesap.bakiye -= miktar;
                    hedefHesap.bakiye += miktar;
                    bankaPayi = (miktar * islemOrani) / 100;
                    hedefPayi = miktar - bankaPayi;
                    banka.toplamPara += bankaPayi;
                    MessageBox.Show("Hedef hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL");

                    string rapor = kaynakNo + " numaralı hesaptan " + hedefNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);

                    rapor = kaynakNo + " numaralı hesabınızdan " + hedefNo + " numaralı hesaba " + hedefPayi + " TL aktarılmıştır. \n Banka işlem ücreti: " + bankaPayi + " TL";
                    kaynakHesap.RaporEkle(rapor, tarih);

                    rapor = kaynakNo + " numaralı hesaptan " + hedefNo + " numaralı hesabınıza " + hedefPayi + " TL aktarılmıştır.";
                    hedefHesap.RaporEkle(rapor, tarih);
                }

            }
            else
                MessageBox.Show("Lütfen Hedef ve Kaynak hesap numaralarını kontrol ediniz.");
        }
        private void MusteriFormu_Load(object sender, EventArgs e)
        {
        }
        private void txtbxParaCekmeHesapNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxParaCekmekMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {

            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxParaYatirHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxParaYatirParaMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void txtbxHavaleGonderilecekHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxHavaleMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {

            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxHavaleGonderenHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxHesapNoHOzet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtbxParaYatirParaMiktari_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
