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
    public partial class AnaSayfaForm : Form
    {

        public AnaSayfaForm()
        {
            InitializeComponent();
        } 

       
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //program açıldığında bir banka nesnesi oluşturup diğer formlara geçişlerde de bu banka nesnesini parametre olarak gönderiyoruz
        Banka banka = new Banka();

        //Anasayfa formunda bir panel var diğer formları da bu panele koyarak geçişleri sağlıyoruz.
        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            //anaform load olduğunda direkt girisformunun içine gelebilmesi için
            panel1.Controls.Clear();
            GirisFormu frmGiris = new GirisFormu(banka);
            frmGiris.TopLevel = false;
            panel1.Controls.Add(frmGiris);
            frmGiris.Show();
            frmGiris.Dock= DockStyle.Fill;
           
        }

       
    }
}
