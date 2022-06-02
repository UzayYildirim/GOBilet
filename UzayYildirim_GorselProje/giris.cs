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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        public Form1 anasayfa; // Ana sayfadaki kullanıcı verilerine ulaşmaya yarar.

        private void button2_Click(object sender, EventArgs e) // Admin bilgilerinin girilip girilmediğini kontrol eder, eğer yoksa normal kullanıcı kaydı olup olmadığını kontrol eder ve girişi sağlar.
        {
            if (txtEmail.Text == "admin@admin.com" && txtSifre.Text == "admin1234") // ADMIN E-Mail: admin@admin.com Şifre: admin1234
            {
                this.anasayfa.admingiris = true;
                this.Close();
            }
            else
            {
                bool kvar = false;
                foreach (var item in ucusliste.kullanicilar)
                {
                    if (item.email == txtEmail.Text && item.sifre == txtSifre.Text)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        anasayfa.kullanicigiris = true;
                        anasayfa.kullanicimail = item.email;
                        kvar = true;
                        break;
                    }
                }
                if (kvar == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verilen bilgiler ile eşleşen bir hesap bulunamadı. Lütfen kayıt ol seçeneğini kullanınız.");
                }
            }
        }

            

        private void giris_Load(object sender, EventArgs e) // Giriş yapılı olup olunmadığını kontrol eder, giriş yapılmış ise giriş yap formunu gizleyip çıkış yap butonunu ve mesajını gösterir.
        {
            if (anasayfa.kullanicimail.Length > 0)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // Kullanıcı kaydı sağlar.
        {
            kullanici k = new kullanici();
            k.email = txtEmail.Text;
            k.sifre = txtSifre.Text;
            ucusliste.kullanicilar.Add(k);
            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");
        }

        private void btnCikis_Click(object sender, EventArgs e) // Çıkış yapmayı sağlar.
        {
            anasayfa.kullanicimail = "";
            anasayfa.lblMail.Text = "";
            anasayfa.kullanicigiris = false;
            panel1.Visible = true;
            panel2.Visible = false;
        }
    }
}
