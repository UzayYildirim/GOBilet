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
    public partial class rastgeleani : Form
    {
        public rastgeleani()
        {
            InitializeComponent();
        }
        int sayac = 3;

        private void rastgeleani_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) // Her sayaç tick'inde kalan zamanı günceller ve süre bittiğinde formu gizler.
        {
            label2.Text = sayac--.ToString();
            if (sayac == -1)
            {
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
