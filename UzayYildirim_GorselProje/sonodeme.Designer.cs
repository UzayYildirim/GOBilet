
namespace UzayYildirim_GorselProje
{
    partial class sonodeme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sonodeme));
            this.kartno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sonkullanma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cvc = new System.Windows.Forms.TextBox();
            this.odemeyap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toplamFiyat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kuponkodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kartno
            // 
            this.kartno.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kartno.Location = new System.Drawing.Point(25, 273);
            this.kartno.MaxLength = 16;
            this.kartno.Name = "kartno";
            this.kartno.Size = new System.Drawing.Size(1099, 46);
            this.kartno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kart Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Son Kullanma Tarihi:";
            // 
            // sonkullanma
            // 
            this.sonkullanma.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonkullanma.Location = new System.Drawing.Point(25, 368);
            this.sonkullanma.MaxLength = 5;
            this.sonkullanma.Name = "sonkullanma";
            this.sonkullanma.Size = new System.Drawing.Size(535, 46);
            this.sonkullanma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(560, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "CVC2";
            // 
            // cvc
            // 
            this.cvc.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvc.Location = new System.Drawing.Point(566, 368);
            this.cvc.MaxLength = 3;
            this.cvc.Name = "cvc";
            this.cvc.Size = new System.Drawing.Size(269, 46);
            this.cvc.TabIndex = 6;
            // 
            // odemeyap
            // 
            this.odemeyap.BackColor = System.Drawing.SystemColors.Window;
            this.odemeyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.odemeyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odemeyap.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeyap.Location = new System.Drawing.Point(566, 479);
            this.odemeyap.Name = "odemeyap";
            this.odemeyap.Size = new System.Drawing.Size(553, 63);
            this.odemeyap.TabIndex = 27;
            this.odemeyap.Text = "Güvenli Ödeme Yap >>";
            this.odemeyap.UseVisualStyleBackColor = false;
            this.odemeyap.Click += new System.EventHandler(this.odemeyap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ödenecek Tutar:";
            // 
            // toplamFiyat
            // 
            this.toplamFiyat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toplamFiyat.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamFiyat.ForeColor = System.Drawing.Color.Coral;
            this.toplamFiyat.Location = new System.Drawing.Point(25, 479);
            this.toplamFiyat.Name = "toplamFiyat";
            this.toplamFiyat.Size = new System.Drawing.Size(535, 63);
            this.toplamFiyat.TabIndex = 32;
            this.toplamFiyat.Text = "750TL";
            this.toplamFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(956, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "DEMO Veri Doldur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::UzayYildirim_GorselProje.Properties.Resources.kartlar;
            this.pictureBox2.Location = new System.Drawing.Point(171, 593);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(782, 65);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UzayYildirim_GorselProje.Properties.Resources.GOBilet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(385, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kuponkodu
            // 
            this.kuponkodu.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuponkodu.Location = new System.Drawing.Point(840, 368);
            this.kuponkodu.Name = "kuponkodu";
            this.kuponkodu.Size = new System.Drawing.Size(279, 46);
            this.kuponkodu.TabIndex = 34;
            this.kuponkodu.TextChanged += new System.EventHandler(this.kuponkodu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(834, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kupon Kodu (Varsa)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1037, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(886, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Kupon kodu uygulandı!";
            this.label6.Visible = false;
            // 
            // sonodeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1144, 690);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kuponkodu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toplamFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odemeyap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cvc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sonkullanma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kartno);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sonodeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoBilet - Ödeme";
            this.Load += new System.EventHandler(this.sonodeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox kartno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sonkullanma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cvc;
        private System.Windows.Forms.Button odemeyap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplamFiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kuponkodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}