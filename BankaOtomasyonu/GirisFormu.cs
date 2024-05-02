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
    partial class GirisFormu : Form
    {
        public GirisFormu(Banka banka)
        {
            InitializeComponent();
            banka=this.banka;
        }
        //bir banka nesnesi oluşturup diğer formlarda da banka nesnesini parametre olarak gönderiyoruz
        Banka banka=new Banka();
       
        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            string musteriNo = txtbxKullaniciAdiMusteriNo.Text;
            string sifre = txtbxSifre.Text;
            bool musteriBulunduMu = false;

            while (musteriBulunduMu != true) { 
                foreach (BireyselMusteri m in banka.BireyselMusteriler)
                {
                    if (musteriNo == m.ID && sifre == m.Sifre)
                    {
                        GirisFormu frmGirisForm = Application.OpenForms["GirisFormu"] as GirisFormu;
                        MusteriFormu formMusteri = new MusteriFormu(banka, m);

                        MessageBox.Show("Hoşgeldiniz" + m.Ad + "" + m.Soyad);
                        formMusteri.ShowDialog();
                        formMusteri.Dock= DockStyle.Fill;
                        musteriBulunduMu = true;
                        break;
                    }
                    else
                        MessageBox.Show("Kayıtlı bireysel müşteri bulunamadı."); 
                }
                foreach (TicariMusteri m in banka.TicariMusteriler)
                {
                    if (musteriNo == m.ID && sifre == m.Sifre)
                    {
                        GirisFormu frmGirisForm = Application.OpenForms["GirisFormu"] as GirisFormu;
                        MusteriFormu formMusteri = new MusteriFormu(banka, m);
                   

                        MessageBox.Show("Hoşgeldiniz" + m.Ad + "" + m.Soyad);
                        formMusteri.ShowDialog();
                        formMusteri.Dock = DockStyle.Fill;
                        musteriBulunduMu = true;
                        break;
                    }
                    else
                        MessageBox.Show("Kayıtlı ticari müşteri bulunamadı.");
                }
            }
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtbxKullaniciAdiMusteriNo.Text;
            string sifre = txtbxSifre.Text;

            foreach (Personel p in banka.personeller)
            {
                if (kullaniciAdi == p.ID && sifre == p.Sifre)
                {
                    
                    PersonelFormu formPersonel = new PersonelFormu(banka);
                    formPersonel.TopLevel = false;
                   
                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;
                    MessageBox.Show("Hoş geldiniz " + p.Ad + "" + p.Soyad);
                }
                else
                    MessageBox.Show("Kayıtlı personel bulunamadı.");
            }
            PersonelFormu frmPersonel = new PersonelFormu(banka);
            frmPersonel.ShowDialog();
        }

        private void btnBankaYoneticisi_Click(object sender, EventArgs e)
        {
            BankaGirisiFormu frmBankaGirisi = new BankaGirisiFormu(banka);
            frmBankaGirisi.ShowDialog();
        }

        private void GirisFormu_Load(object sender, EventArgs e)
        {
            //ana form load olduğunda GirisFormunun gelmesi için
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HakkımızdaFormu frmHakkimizda = new HakkımızdaFormu();
            
            frmHakkimizda.ShowDialog();
        }

        private void indirimiYakalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndirimiYakalaFormu frmIndirim = new IndirimiYakalaFormu();

            frmIndirim.ShowDialog();
        }
    }
}
