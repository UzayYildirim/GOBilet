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
    public partial class listeucus : Form
    {
        public listeucus()
        {
            InitializeComponent();
        }

        public Form1 anasayfa;
        bool gidisdonus = false;
        int asama = 0; // 0: Gidiş Seç, 1: Dönüş Seç

        private void listeucus_Load(object sender, EventArgs e) // Uçuşların listesini oluşturur.
        {
            for (int i = 0; i < ucusliste.gidenucuslar.Count; i++)
            {
                ucus u = ucusliste.gidenucuslar[i];
                int panelno = i + 1;
                Panel p = (Panel)pnlGidis.Controls["panel" + panelno.ToString()];
                p.Controls["kalkis" + panelno.ToString()].Text = u.kalkis;
                p.Controls["inis" + panelno.ToString()].Text = u.varis;
                p.Controls["fiyat" + panelno.ToString()].Text = u.fiyat.ToString() + " TL";
                p.Controls["saat" + panelno.ToString()].Text = u.saat.ToString();
                PictureBox pb = (PictureBox)p.Controls["resim" + panelno.ToString()];
                if (u.firma == "THY")
                {
                    pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_thy;
                }
                else if (u.firma == "Pegasus")
                {
                    pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_pegasus;
                }
                else if (u.firma == "SunExpress")
                {
                    pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_sunexpress;
                }
                else if (u.firma == "AnadoluJet")
                {
                    pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_anadolu;
                }

                gidisdonus = u.gidisdonus;
            }
            if (gidisdonus == true)
            {
                cmdIleri.Text = "Dönüş Biletini Seç >";
            }
        }

        private void panelsec(int panelno) // Uçuş panellerinin seçimini sağlar.
        {
            for (int i = 1; i <= 3; i++) // Öncelikle tüm panellerin seçimini kaldırır.
            {
                Panel p = (Panel)pnlGidis.Controls["panel" + i.ToString()];
                p.BorderStyle = BorderStyle.None;
            }
            if (panelno > 0) // Seçilen paneli belirtmek için border türünü 3d yapar.
            {
                Panel psecili = (Panel)pnlGidis.Controls["panel" + panelno.ToString()];
                psecili.BorderStyle = BorderStyle.Fixed3D;
                cmdIleri.Enabled = true;
                if (asama == 0)
                {
                    ucusliste.gidenucus = ucusliste.gidenucuslar[panelno-1];
                }
                else
                {
                    ucusliste.donenucus = ucusliste.donenucuslar[panelno-1];
                }
            }
        }

        private void resim1_Click(object sender, EventArgs e) // Seçilen panel numarasını fonksiyona iletir.
        {
            Control ctrl = (Control)sender;
            int panelno = int.Parse(ctrl.Tag.ToString());
            panelsec(panelno);
        }

        private void cmdIleri_Click(object sender, EventArgs e)
        {
            if (asama == 0)
            {
                if (gidisdonus == true)
                {
                    if (ucusliste.gidenucus == null) // Uçuş seçilip seçilmediğini kontrol eder.
                    {
                        MessageBox.Show("Devam etmek için lütfen bir uçuş seçiniz.");
                        return;
                    }
                    panelsec(0);
                    asama = 1;
                    for (int i = 0; i < ucusliste.donenucuslar.Count; i++) // Dönen uçuş listesini oluşturur.
                    {
                        ucus u = ucusliste.donenucuslar[i];
                        int panelno = i + 1;
                        Panel p = (Panel)pnlGidis.Controls["panel" + panelno.ToString()];
                        p.Controls["kalkis" + panelno.ToString()].Text = u.kalkis;
                        p.Controls["inis" + panelno.ToString()].Text = u.varis;
                        p.Controls["fiyat" + panelno.ToString()].Text = u.fiyat.ToString() + " TL";
                        p.Controls["saat" + panelno.ToString()].Text = u.saat.ToString();
                        PictureBox pb = (PictureBox)p.Controls["resim" + panelno.ToString()];
                        if (u.firma == "THY")
                        {
                            pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_thy;
                        }
                        else if (u.firma == "Pegasus")
                        {
                            pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_pegasus;
                        }
                        else if (u.firma == "SunExpress")
                        {
                            pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_sunexpress;
                        }
                        else if (u.firma == "AnadoluJet")
                        {
                            pb.Image = UzayYildirim_GorselProje.Properties.Resources.gobilet_anadolu;
                        }
                    }
                    cmdIleri.Text = "Devam Et >";
                }
                else
                {
                    if (ucusliste.gidenucus != null) // Giden uçuş seçilmişse ödeme ekranına geçer.
                    {
                        odeme fodeme = new odeme();
                        fodeme.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Devam etmek için lütfen bir uçuş seçiniz.");
                    }
                }
            }
            else
            {
                if (ucusliste.donenucus != null) // Uçuşun seçilip seçilmediğini kontrol eder.
                {
                    odeme fodeme = new odeme();
                    fodeme.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Devam etmek için lütfen bir uçuş seçiniz.");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa.Show();
            this.Close();
        }
    }
}
