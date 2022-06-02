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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        int ucusfiyati = 0;
        int ekstrafiyati = 0;

        private void odeme_Load(object sender, EventArgs e) // Yolcu sayısına göre panelleri görsel olarak düzenler ve aktif eder. Ardından seçili uçuşun/uçuşların fiyatını görüntüler..
        {
            int yolcus = ucusliste.gidenucus.ksayisi;
            for (int i = 1; i <= yolcus; i++)
            {
                this.Controls["yolcu" + i].Enabled = true;
                this.Controls["yolcu" + i].BackColor = Color.FromArgb(138, 199, 219);
                ComboBox yemekbox = (ComboBox)this.Controls["yolcu" + i].Controls["comboYemek" + i];
                for (int j = 0; j < Program.adminform.yemekler.Items.Count; j++)
                {
                    yemekbox.Items.Add(Program.adminform.yemekler.Items[j]);
                }
            }

            ucusfiyati = ucusliste.gidenucus.fiyat;
            if (ucusliste.donenucus != null) // Dönüş uçuşu varsa fiyatını ekler.
            {
                ucusfiyati += ucusliste.donenucus.fiyat;
            }
            ucusfiyati = ucusfiyati * yolcus; // Bilet fiyatını yolcu sayısı ile çarparak final bilet fiyatını bulur.
            lblUcus.Text = ucusfiyati.ToString() + " TL";
        }

        private bool yolcuKaydet() // Yolcu bilgilerini yolcu sayısını göz önünde bulundurarak kayıt eder.
        {
            int yolcus = ucusliste.gidenucus.ksayisi;
            for (int i = 1; i <= yolcus; i++)
            {
                TextBox adi = (TextBox)this.Controls["yolcu" + i].Controls["ad" + i];
                TextBox soyadi = (TextBox)this.Controls["yolcu" + i].Controls["soyad" + i];
                TextBox tc = (TextBox)this.Controls["yolcu" + i].Controls["tc" + i];
                DateTimePicker dt = (DateTimePicker)this.Controls["yolcu" + i].Controls["dt" + i];
                if (adi.Text.Trim().Length == 0 || soyadi.Text.Trim().Length == 0 || tc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    ucusliste.yolcular = new List<yolcu>();
                    return false;
                }
                yolcu y = new yolcu();
                y.adi = adi.Text;
                y.soyadi = soyadi.Text;
                y.tcno = tc.Text;
                y.dtarihi = dt.Value.ToString("dd/MM/yyyy");
                ucusliste.yolcular.Add(y);
            }
            return true;
        }

        private void ekstratopla() // Seçili ekstraların fiyatını toplar ve gösterir.
        {
            int ekstra = 0;
            int yolcus = ucusliste.gidenucus.ksayisi;
            for (int i = 1; i <= yolcus; i++)
            {
                GroupBox gb = (GroupBox)this.Controls["yolcu" + i];
                CheckBox bc = (CheckBox)gb.Controls["bc" + i];
                if (bc.Checked == true)
                {
                    ekstra += 1000;
                }
                ComboBox comboyemek = (ComboBox)gb.Controls["comboYemek" + i];
                if (comboyemek.SelectedIndex > 0)
                {
                    string yemekadi = comboyemek.SelectedItem.ToString();
                    int j = yemekadi.IndexOf(" ");
                    string strfiyat = yemekadi.Substring(0, j);
                    int yemekfiyati = int.Parse(strfiyat);
                    ekstra += yemekfiyati;
                }
            }
            if (ucusseti.Checked)
            {
                ekstra += 65;
            }
            if (maket.Checked)
            {
                ekstra += 480;
            }
            ekstrafiyati = ekstra;
            lblEkstra.Text = ekstra.ToString() + " TL";
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            ekstratopla();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekstratopla();
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            ekstratopla();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ekstratopla();
        }

        private void btnOdeme_Click(object sender, EventArgs e) // Mevcut bilgileri ve fiyatları kayıt eder, ödeme ekranını gösterir.
        {
            if (yolcuKaydet()==true)
            {
                sonodeme frm = new sonodeme();
                frm.toplamtutar = ekstrafiyati + ucusfiyati;
                frm.yolcusayfa = this;
                frm.Show();
                this.Hide();
            }
        }
    }
}
