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
    public partial class checkin : Form
    {
        public checkin()
        {
            InitializeComponent();
        }

        private void checkin_Load(object sender, EventArgs e)
        {
            if (ucusliste.yolcular.Count == 0) // Önceden oluşturulmuş bilet var mı diye kontrol eder, varsa PNR no gösterir.
            {
                sonpnr.Text = "Bilet bulunamadı.";
                return;
            }
            yolcu y = ucusliste.yolcular[0];
            sonpnr.Text = y.pnrno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPNR.Text.ToUpper() == sonpnr.Text) // Girilen değer alınmış olan biletin PNR'ına uyuyorsa Boarding Pass gösterir.
            {
                MessageBox.Show("Check-in başarılı!");
                bpass bilet = new bpass();
                bilet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu PNR numarası ile bir bilet bulunamadı.");
            }
        }
    }
}
