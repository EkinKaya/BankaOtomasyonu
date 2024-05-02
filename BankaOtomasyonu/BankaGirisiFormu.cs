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
     partial class BankaGirisiFormu : Form //public i sildik tutarsiz erişilebilirlik olmaması için
    {
        public BankaGirisiFormu(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
            this.dtGridViwPersonelListele.DataSource = banka.personeller;
        }

        Banka banka;
        //Gerekli bilgiler Txt Boxlara girildi Ekle butonuna basıldı.

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string Ad = txtbxPersonelAd.Text; //Personel Bilgilerini textbox'dan alıp yeni nesneye ekliyoruz.
            string Soyad = txtbxPersonelSoyad.Text;
            string ID = txtbxPersonelKullaniciAdi.Text;
            string Sifre = txtbxPersonelSifre.Text;

            txtbxPersonelAd.Clear(); //Personel eklendikten sonra textBoxları temizliyoruz.
            txtbxPersonelSoyad.Clear();
            txtbxPersonelKullaniciAdi.Clear();
            txtbxPersonelSifre.Clear();

            banka.PersonelEkle(Ad, Soyad, ID, Sifre); //Personel bilgilerini Banka sınıfındaki PersonelEkle metoduna gönderiyoruz.        

         
           
            this.dtGridViwPersonelListele.DataSource = banka.personeller; //gridView öğesine personeller listesini yazdırıyoruz.

            string rapor = ID + " kullanıcı adına sahip kişi bankaya personel olarak eklendi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);
        }



        private void BankaGirisiFormu_Load(object sender, EventArgs e)
        {

          this.dtGridViwPersonelListele.DataSource = banka.personeller;
        }


     
        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = txtbxPersonelSilAdi.Text;
            txtbxPersonelKullaniciAdi.Clear();

            banka.PersonelSil(ID);
         
            MessageBox.Show("Personel silindi.");

           dtGridViwPersonelListele.DataSource = null;
           //this.dtGridViwPersonelListele.Rows.Clear();
       
            this.dtGridViwPersonelListele.DataSource = banka.personeller;

            string rapor = ID + " kullanici adına sahip banka personeli silindi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);
        }

        private void btnRaporuListele_Click(object sender, EventArgs e)
        {
            dtGridViwGelirGiderRaporu.DataSource = null;
            dtGridViwGelirGiderRaporu.DataSource = banka.BankaRaporListesi;
            lblBankaHazinesi.Text = "Toplam hazine:" + banka.toplamPara + "TL";
        }

        //geri butonları şu an çalışmıyor
        private void btnAnasayfayaDon1_Click(object sender, EventArgs e)
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

        private void btnAnasayfayaDon2_Click(object sender, EventArgs e)
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

        private void btnAnasayfayaDon3_Click(object sender, EventArgs e)
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

        private void btnAnasayfayaDon4_Click(object sender, EventArgs e)
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

        
        
        private void dtGridViwPersonelListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPgPersonelListele_Click(object sender, EventArgs e)
        {

        }

        private void txtbxPersonelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece harf girilmesi için 
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtbxPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Sadece harf girilmesi için 
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
