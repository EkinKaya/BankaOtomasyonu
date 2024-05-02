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
    public partial class IndirimiYakalaFormu : Form
    {
        public IndirimiYakalaFormu()
        {
            InitializeComponent();
        }

        private void btnIndirimiYakala_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int indirim = random.Next(10, 70);

            MessageBox.Show("Tebrikler %" + indirim + " indirim kazandınız! ");
        }
    }
}
