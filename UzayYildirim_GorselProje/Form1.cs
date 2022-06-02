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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        public bool admingiris = false;
        public bool kullanicigiris = false;
        public string kullanicimail = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ucusBul() // Girilen değerleri formatlayıp yolcu bilgi class'ına gönderir, formu ana sayfa olarak belirler ve bulunan uçuşlar listesini açar.
        {
            ucusliste.yolcular = new List<yolcu>();
            if (cmbKalkis.SelectedItem == null || cmbVaris.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kalkış ve varış havaalanlarını seçiniz.");
                ok1.Visible = true;
                ok2.Visible = true;
            }
            else
            {
                string tarih = dtGidis.Value.ToString("dd/MM/yyyy");
                int ksayisi = int.Parse(cmbKisi.SelectedItem.ToString());
                ucusliste.gidenucuslar = ucusliste.ucusdoldur(cmbKalkis.SelectedItem.ToString(), cmbVaris.SelectedItem.ToString(), tarih, ksayisi, rdGidisDonus.Checked);
                if (rdGidisDonus.Checked)
                {
                    string tarihdonus = dtDonus.Value.ToString("dd/MM/yyyy");
                    ucusliste.donenucuslar = ucusliste.ucusdoldur(cmbVaris.SelectedItem.ToString(), cmbKalkis.SelectedItem.ToString(), tarihdonus, ksayisi, rdGidisDonus.Checked);
                }
                listeucus fucuslar = new listeucus();
                fucuslar.anasayfa = this;
                fucuslar.Show();
                this.Hide();
            }
        }

        public void havaalaniyukle() // Havalimanlarını admin paneline girilmiş olan listeden çeker ve gösterir.
        {
            cmbKalkis.Items.Clear();
            cmbVaris.Items.Clear();
            for (int i = 0; i < Program.adminform.havaalanlari.Items.Count; i++)
            {
                cmbKalkis.Items.Add(Program.adminform.havaalanlari.Items[i]);
                cmbVaris.Items.Add(Program.adminform.havaalanlari.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucusBul();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkin checkinform = new checkin();
            checkinform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) // Login formunu gösterir ve form kapatıldıktan sonra admin panelinden güncel havalimanı listesini yükler.
        {
            admingiris = false;
            giris loginform = new giris();
            loginform.anasayfa = this;
            loginform.ShowDialog();
            if (admingiris == true)
            {
                this.Hide();
                Program.adminform.WindowState = FormWindowState.Normal;
                Program.adminform.ShowDialog();
                havaalaniyukle();
                this.Show();
            }
            else if (kullanicigiris == true)
            {
                lblMail.Visible = true;
                lblMail.Text = kullanicimail;
            }
        }

        private void button5_Click(object sender, EventArgs e) // Kalkış ve varış havalimanlarının aynı olup olmadığını kontrol eder.
        {
            if (cmbKalkis.SelectedItem == cmbVaris.SelectedItem)
            {
                MessageBox.Show("Kalkış ve Varış havalimanları aynı olamaz. Lütfen başka bir havalimanı seçiniz.");
            }
            else
            {
                ucusBul();
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Form yüklendiğinde havaalanları listesini yükleme fonksiyonunu çağırır.
        {
            cmbKisi.SelectedIndex = 0;
            havaalaniyukle();
        }

        private void button6_Click(object sender, EventArgs e) // Rastgele lokasyon belirler ve animasyon formunu açar.
        {
            rastgeleani rani = new rastgeleani();
            rani.ShowDialog();
            cmbVaris.SelectedIndex = (rnd.Next(0, cmbVaris.Items.Count - 1));


        }

        private void rdGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            dtDonus.Enabled = true;
        }

        private void rdTekYon_CheckedChanged(object sender, EventArgs e)
        {
            dtDonus.Enabled = false;
        }
    }
}
