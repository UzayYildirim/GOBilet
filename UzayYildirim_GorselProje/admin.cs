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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void havaekle_Click(object sender, EventArgs e) // Havalimanı ekler.
        {
            if (txtHavalimani.Text.Trim().Length > 0)
            {
                havaalanlari.Items.Add(txtHavalimani.Text.Trim());
                txtHavalimani.Clear();
            }
            else
            {
                MessageBox.Show("Havalimanı boş bırakılamaz.");
            }
            havasayi.Text = havaalanlari.Items.Count.ToString();
        }

        private void yemekekle_Click(object sender, EventArgs e) // Yemek ekler.
        {
            int yemekfiyati = 0;
            try
            {
                yemekfiyati = Convert.ToInt32(txtFiyat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı yemek fiyatı girişi yapıldı.");
                return;
            }
            if (txtYemek.Text.Trim().Length > 0)
            {
                yemekler.Items.Add(yemekfiyati + " TL | " + txtYemek.Text.Trim()); // Eklenen yemeği listeye formatlı yerleştirir.
                txtYemek.Clear();
                txtFiyat.Clear();
            }
            else
            {
                MessageBox.Show("Yemek Adı boş bırakılamaz.");
            }
            yemeksayi.Text = yemekler.Items.Count.ToString();
        }

        private void havasil_Click(object sender, EventArgs e) // Listede seçili havalimanını siler.
        {
            havaalanlari.Items.Remove(havaalanlari.SelectedItem);
            havasayi.Text = havaalanlari.Items.Count.ToString();
        }

        private void yemeksil_Click(object sender, EventArgs e) // Listede seçili yemeği siler.
        {
            yemekler.Items.Remove(yemekler.SelectedItem);
            yemeksayi.Text = yemekler.Items.Count.ToString();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
