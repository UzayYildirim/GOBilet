using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYildirim_GorselProje
{
    public partial class sonodeme : Form
    {
        public sonodeme()
        {
            InitializeComponent();
        }

        public odeme yolcusayfa;
        public int toplamtutar = 0;

        private void kuponKontrol() // Kupon kodunun doğruluğunu kontrol eder, doğruysa gizler ve mesaj görüntüler.
        {
            if (kuponkodu.Enabled == true && kuponkodu.Text.ToUpperInvariant() == "KEŞİF20")
            {
                kuponkodu.Enabled = false;
                toplamtutar -= (toplamtutar / 100) * 20;
                toplamFiyat.Text = toplamtutar.ToString() + " TL";
                label6.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) // DEMO kart bilgilerini yükler.
        {
            kartno.Text = "4716204966718541";
            sonkullanma.Text = "03/23";
            cvc.Text = "426";
            kuponkodu.Text = "KEŞİF20";
            kuponKontrol();
        }

        private void sonodeme_Load(object sender, EventArgs e) // Toplam tutarı form yüklendiğinde görüntüler.
        {
            toplamFiyat.Text = toplamtutar.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yolcusayfa.Show();
            this.Close();
        }

        private void kuponkodu_TextChanged(object sender, EventArgs e)
        {
            kuponKontrol();
        }

        private void odemeyap_Click(object sender, EventArgs e) // Alanlardaki bilgileri kontrol eder ve ödemeyi gerçekleştirir. (Capture)
        {
            if (kartno.Text.Length < 16 || sonkullanma.Text.Length < 5 || cvc.Text.Length < 3)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.");
            }
            else
            {
                odemebasarili fodemebasarili = new odemebasarili();
                fodemebasarili.Show();
                this.Close();
            }
        }
    }
}
