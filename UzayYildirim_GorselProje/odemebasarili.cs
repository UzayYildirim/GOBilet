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
    public partial class odemebasarili : Form
    {
        public odemebasarili()
        {
            InitializeComponent();
        }

        string pnr = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pnrOlustur() // Rastgele PNR kodu oluşturur. (<HARF> - <SAYI> şeklinde)
        {
            Random rnd = new Random();
            string harfler = "ABCDEFGHJKLMNOPRSTUVXYZQ";
            string pnr1 = "";
            string pnr2 = "";
            for (int i = 0; i < 4; i++)
            {
                int j = rnd.Next(0,harfler.Length - 1);
                pnr1 += harfler.Substring(j, 1);
            }
            for (int i = 0; i < 4; i++)
            {
                int j = rnd.Next(0, 9);
                pnr2 += j;
            }
            pnr = pnr1 + "-" + pnr2;
        }
        private void odemebasarili_Load(object sender, EventArgs e) // PNR oluşturma fonksiyonunu çağırır ve görüntüler. Tüm yolcular için PNR numarasını eşitler.
        {
            pnrOlustur();
            pnrlabel.Text = "PNR: " + pnr;
            foreach (var item in ucusliste.yolcular)
            {
                item.pnrno = pnr;
            }
        }

        private void checkin_Click(object sender, EventArgs e)
        {
            checkin checkinform = new checkin();
            checkinform.ShowDialog();
        }
    }
}
