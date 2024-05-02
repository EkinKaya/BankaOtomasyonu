using System;
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
     partial class PersonelFormu : Form //publici sildik erişebilirliğin tutarlılığı  için 
    {


        public PersonelFormu(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
       
        }


        Banka banka;

       
        private void tabPgMusteriEkle_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f1 = Application.OpenForms["AnaSayfaForm"] as AnaSayfaForm;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisFormu f3 = new GirisFormu(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }
        private void tbPgHesapAç_Click(object sender, EventArgs e)
        {
            AnaSayfaForm f1 = Application.OpenForms["AnaSayfaForm"] as AnaSayfaForm;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisFormu f3 = new GirisFormu(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {

            if (rdbtnBireyselMusteri.Checked == true)
            { //Bireysel Müşteri ekleniyorsa
                bool musteriTipi = true;
                string ad = txtbxMusteriAd.Text;
                string soyad = txtbxMusteriSoyad.Text;
                string ID = txtbxMusteriNumarasi.Text;
                string sifre = txtbxMusteriSifresi.Text;

                DateTime tarih = dtTmPckrMusteriEkleTarih.Value;

                banka.MusteriEkle(musteriTipi, ad, soyad, ID, sifre, tarih);

                string rapor = ID + " musteri numarasına sahip " + ad + " " + soyad + " kişisi Bireysel Müşteri olarak bankaya eklendi.";
                banka.RaporEkle(rapor, tarih);
            }
            else if (rdiobtnTicariMusteri.Checked == true) //Ticari Müşteri Ekleniyorsa
            {
                bool musteriTipi = false;
                string ad = txtbxMusteriAd.Text;
                string soyad = txtbxMusteriSoyad.Text;
                string ID = txtbxMusteriNumarasi.Text;
                string sifre = txtbxMusteriSifresi.Text;

                DateTime tarih = dtTmPckrMusteriEkleTarih.Value;
                banka.MusteriEkle(musteriTipi, ad, soyad, ID, sifre, tarih);

                string rapor = ID + " musteri numarasına sahip " + ad + " " + soyad + " kişisi Ticari Müşteri olarak bankaya eklendi.";
                banka.RaporEkle(rapor, tarih);
            }
            else //Müşteri tipi girilmemişse
            {
                MessageBox.Show("Lütfen müşteri tipini seçiniz.");
            }
        }

        private void btnYeniHesapAc_Click(object sender, EventArgs e)
        {
            string musteriNo = txtbxHesapAcMusteriNo.Text;
            int ekBakiye = Convert.ToInt32(txtbxYeniHesapEkHesap.Text);

            foreach (BireyselMusteri m in banka.BireyselMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    m.YeniHesapAc(ekBakiye);

                    string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
            foreach (TicariMusteri m in banka.TicariMusteriler)//Müşteri ticari müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    m.YeniHesapAc(ekBakiye);

                    string rapor = m.ID + " kullanıcı adına sahip Ticari Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            int ekBakiye = Convert.ToInt32(txtbxHesapSilHesapNo.Text);
            int hesapNo = Convert.ToInt32(txtbxHesapSilHesapNo.Text);

            foreach (BireyselMusteri m in banka.BireyselMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.MusterininHesaplari.ToList())//Her bir müşterinin hesaplar listesini tarayarak girilen hesap numarasına ait müşteriyi buluyoruz.
                {
                    if (ekBakiye == 0)
                    {
                        m.HesabıSil(hesapNo);//Müşterinin HesapSil metodunu çalıştırıyoruz.

                        string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşterinin " + hesapNo + " numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);
                    }
                    else
                        MessageBox.Show("Bakiye olan hesapta silme işlemi yapılamaz.");
                }

            }
            foreach (TicariMusteri m in banka.TicariMusteriler)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                foreach (Hesap h in m.MusterininHesaplari.ToList())
                {
                   
                        m.HesabıSil(hesapNo);

                        string rapor = m.ID + " kullanıcı adına sahip Ticari Müşterinin " + hesapNo + " numaralı hesabı silindi.";
                        DateTime tarih = DateTime.Today;
                        banka.RaporEkle(rapor, tarih);
                         

                }
            }
        }

        //hesap aç anasayfaya dön butonu
        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            //şu an açık olan formun kapanması gerek ve anasayfaya dönecek
            AnaSayfaForm anaSayfaForm= new AnaSayfaForm();
            anaSayfaForm.ShowDialog();
            Panel panel1 = new Panel();
            panel1.Controls.Clear();
            GirisFormu frmGiris = new GirisFormu(banka);
            frmGiris.TopLevel = false;
            panel1.Controls.Add(frmGiris);
            frmGiris.Show();
            frmGiris.Dock = DockStyle.Fill; 

            

        }

        private void btnAnasayfayaDonHesapActa_Click(object sender, EventArgs e)
        {
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.ShowDialog();
            Panel panel1 = new Panel();
            panel1.Controls.Clear();
            GirisFormu frmGiris = new GirisFormu(banka);
            frmGiris.TopLevel = false;
            panel1.Controls.Add(frmGiris);
            frmGiris.Show();
            frmGiris.Dock = DockStyle.Fill;
        }

        private void btnAnasayfayaDonHesapSil_Click(object sender, EventArgs e)
        {
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.ShowDialog();
            Panel panel1 = new Panel();
            panel1.Controls.Clear();
            GirisFormu frmGiris = new GirisFormu(banka);
            frmGiris.TopLevel = false;
            panel1.Controls.Add(frmGiris);
            frmGiris.Show();
            frmGiris.Dock = DockStyle.Fill;
        }

        private void txtbxMusteriAd_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Sadece harf girilmesi için 
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtbxMusteriSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Sadece harf girilmesi için 
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtbxMusteriNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbxHesapAcMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtbxYeniHesapEkHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //saadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtbxHesapSilHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakam girilmesi için
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void PersonelFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
