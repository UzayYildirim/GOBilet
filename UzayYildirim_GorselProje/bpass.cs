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
    public partial class bpass : Form
    {
        public bpass()
        {
            InitializeComponent();
        }

        private void gidisGoster() // Gidiş Boarding Pass'ini oluşturur.
        {
            yolcu y = ucusliste.yolcular[0];
            txtPNR.Text = y.pnrno;
            txtSaat.Text = ucusliste.gidenucus.saat;
            txtSaat2.Text = ucusliste.gidenucus.saat;
            txtSaat2.Text = ucusliste.gidenucus.saat;
            txtTarih.Text = ucusliste.gidenucus.tarih;
            txtTarih2.Text = ucusliste.gidenucus.tarih;
            txtKalkis.Text = ucusliste.gidenucus.kalkis;
            txtKalkis2.Text = ucusliste.gidenucus.kalkis;
            txtVaris.Text = ucusliste.gidenucus.varis;
            txtVaris2.Text = ucusliste.gidenucus.varis;
            lblFirma.Text = ucusliste.gidenucus.firma;

            if (ucusliste.gidenucus.firma == "THY")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_thy;
            }
            else if (ucusliste.gidenucus.firma == "Pegasus")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_pegasus;
            }
            else if (ucusliste.gidenucus.firma == "SunExpress")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_sunexpress;
            }
            else if (ucusliste.gidenucus.firma == "AnadoluJet")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_anadolu;
            }


            string yolculistesi = "";

            foreach (var item in ucusliste.yolcular)
            {
                yolculistesi += item.adi + " " + item.soyadi + " | " + item.dtarihi + " | TC: " + item.tcno + "\r\n";
            }
            txtYolcular.Text = yolculistesi;
            txtYolcular2.Text = yolculistesi;
        }

        private void donusGoster() // Dönüş Boarding Pass'ini oluşturur.
        {
            yolcu y = ucusliste.yolcular[0];
            txtPNR.Text = y.pnrno;
            txtSaat.Text = ucusliste.donenucus.saat;
            txtSaat2.Text = ucusliste.donenucus.saat;
            txtSaat2.Text = ucusliste.donenucus.saat;
            txtTarih.Text = ucusliste.donenucus.tarih;
            txtTarih2.Text = ucusliste.donenucus.tarih;
            txtKalkis.Text = ucusliste.donenucus.kalkis;
            txtKalkis2.Text = ucusliste.donenucus.kalkis;
            txtVaris.Text = ucusliste.donenucus.varis;
            txtVaris2.Text = ucusliste.donenucus.varis;
            lblFirma.Text = ucusliste.donenucus.firma;

            if (ucusliste.donenucus.firma == "THY")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_thy;
            }
            else if (ucusliste.donenucus.firma == "Pegasus")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_pegasus;
            }
            else if (ucusliste.donenucus.firma == "SunExpress")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_sunexpress;
            }
            else if (ucusliste.donenucus.firma == "AnadoluJet")
            {
                logo.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_anadolu;
            }

            string yolculistesi = "";

            foreach (var item in ucusliste.yolcular) // Tüm yolcuların bilgilerini yolcular ve passengers kısımlarına basar.
            {
                yolculistesi += item.adi + " " + item.soyadi + " | " + item.dtarihi + " | TC: " + item.tcno + "\r\n";
            }
            txtYolcular.Text = yolculistesi;
            txtYolcular2.Text = yolculistesi;
        }

        private void bpass_Load(object sender, EventArgs e) // Form yüklendiğinde fonksiyonu çağırır.
        {
            gidisGoster();
        }

        private void bpass_FormClosed(object sender, FormClosedEventArgs e) // Form kapandığında check-in ekranına döner.
        {
            checkin fcheckin = new checkin();
            fcheckin.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Yazdırma ekranını açar (Gerçek bir yazdırma fonksiyonu sunmaz.)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void btnDonusKart_Click_1(object sender, EventArgs e) // Ekrandaki karta göre diğer kartı gösterir.
        {
            if (ucusliste.donenucus != null)
            {
                if (btnDonusKart.Text is "Dönüş Kartı >")
                {
                    donusGoster();
                    btnDonusKart.Text = "< Gidiş Kartı";
                }
                else
                {
                    gidisGoster();
                    btnDonusKart.Text = "Dönüş Kartı >";
                }
            }
            else
            {
                MessageBox.Show("Dönüş uçuşunuz bulunmuyor.");
            }
        }
    }
}
