
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        int sayac = 60;
        int puan = 0;
        Atik atik;
        AtikKutusu organicAtikKutusu;
        AtikKutusu kagitKutusu;
        AtikKutusu camKutusu;
        AtikKutusu metalKutusu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  TIMER INTERVAL AYARI (1SN)
            timer1.Interval = 1000;
        }
        //  CIKIS
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //  YENI OYUN 
        private void newGame_Click(object sender, EventArgs e)
        {
            //  SAYAC BASLANGIC
            sayac = 60;
            //  ATIK OLUSTUR
            atik = new Atik();
            //  ATIK IMAGE GETIRME
            atikPb.Image = atik.Image;
            timer1.Start();
            //  PUAN ATAMA VE YAZDIRMA
            puan = 0;
            puanTextBox.Text = Convert.ToString(puan);

            //  ATIK KUTULARI OLUSTURMA
            organicAtikKutusu = new AtikKutusu("Organik Atık Kutusu");
            kagitKutusu = new AtikKutusu("Kağıt Kutusu");
            camKutusu = new AtikKutusu("Cam Kutusu");
            metalKutusu = new AtikKutusu("Metal Kutusu");

            //  LISTBOXLARI TEMIZLEME
            organicListBox.Items.Clear();
            organicAtikPb.Value = 0;

            kagitListBox.Items.Clear();
            kagitPb.Value = 0;

            camListBox.Items.Clear();
            camPb.Value = 0;

            metalListBox.Items.Clear();
            metalPb.Value = 0;

            //  LISTBOXLARI AKTIF ETME
            organicListBox.Enabled = true;
            kagitListBox.Enabled = true;
            camListBox.Enabled = true;
            metalListBox.Enabled = true;

            //  ATIK EKLEME BUTONLARI AKTIF ETME
            organicButton.Enabled = true;
            paperButton.Enabled = true;
            glassButton.Enabled = true;
            metalicButton.Enabled = true;

            //  ATIK KUTUSU BOSALTMA AKTIF ETME
            organicEmptyButton.Enabled = true;
            kagitEmptyButton.Enabled = true;
            camEmptyButton.Enabled = true;
            metalEmptyButton.Enabled = true;


        }
        
        //  TIMER PROCESS
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  OYUN SURESI BITTIYSE
            if (sayac <= 0)
            {
                timer1.Stop();
                organicListBox.Enabled = false;
                kagitListBox.Enabled = false;
                camListBox.Enabled = false;
                metalListBox.Enabled = false;

                organicButton.Enabled = false;
                paperButton.Enabled = false;
                glassButton.Enabled = false;
                metalicButton.Enabled = false;

                organicEmptyButton.Enabled = false;
                kagitEmptyButton.Enabled = false;
                camEmptyButton.Enabled = false;
                metalEmptyButton.Enabled = false;

            }
            else
            {
                sayac--;
                sureTextBox.Text = sayac.ToString();
            }
        }

        //  ORGANIK ATIK EKLE
        private void organicButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur== "Organik Atık Kutusu")
            {
                if (organicAtikKutusu.Ekle(atik))
                {
                    puan += atik.Hacim;
                    puanTextBox.Text = Convert.ToString(puan);
                    organicListBox.Items.Add(atik.Ad + "(" + atik.Hacim + ")");
                    organicAtikPb.Value = organicAtikKutusu.DolulukOrani;

                    atik = new Atik();
                    atikPb.Image = atik.Image;
                }
                   
            }
        }
        //  KAGIT EKLE
        private void paperButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Kağıt Kutusu")
            {
                if (kagitKutusu.Ekle(atik))
                {
                    puan += atik.Hacim;
                    puanTextBox.Text = Convert.ToString(puan);
                    kagitListBox.Items.Add(atik.Ad + "(" + atik.Hacim + ")");
                    kagitPb.Value = kagitKutusu.DolulukOrani;

                    atik = new Atik();
                    atikPb.Image = atik.Image;
                }
                
            }
        }
        //  CAM EKLE
        private void glassButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Cam Kutusu")
            {
                if (camKutusu.Ekle(atik))
                {
                    puan += atik.Hacim;
                    puanTextBox.Text = Convert.ToString(puan);
                    camListBox.Items.Add(atik.Ad + "(" + atik.Hacim + ")");
                    camPb.Value = camKutusu.DolulukOrani;

                    atik = new Atik();
                    atikPb.Image = atik.Image;
                }
            }
        }
        //  METAL EKLE
        private void metalicButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Metal Kutusu")
            {
                if (metalKutusu.Ekle(atik))
                {
                    puan += atik.Hacim;
                    puanTextBox.Text = Convert.ToString(puan);

                    metalListBox.Items.Add(atik.Ad + "(" + atik.Hacim + ")");
                    metalPb.Value = metalKutusu.DolulukOrani;

                    atik = new Atik();
                    atikPb.Image = atik.Image;
                }
            }
        }

        private void metalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //  ORGANIK ATIK BOSALT
        private void organicEmptyButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Organik Atık Kutusu")
            {
                if (organicAtikKutusu.Bosalt())
                {
                    puan += organicAtikKutusu.BosaltmaPuani;
                    puanTextBox.Text = Convert.ToString(puan);
                    
                    organicListBox.Items.Clear();
                    sayac += 0;
                    organicAtikPb.Value = 0;
                }
            }
        }
        //  KAGIT KUTUSU BOSALT
        private void kagitEmptyButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Kağıt Kutusu")
            {
                if (kagitKutusu.Bosalt())
                {
                    puan += kagitKutusu.BosaltmaPuani;
                    puanTextBox.Text = Convert.ToString(puan);
                    kagitListBox.Items.Clear();
                    sayac += 3;
                    kagitPb.Value = 0;
                }

            }
        }
        //  CAM ATIK KUTUSU BOSALT
        private void camEmptyButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Cam Kutusu")
            {
                if (camKutusu.Bosalt())
                {
                    puan += camKutusu.BosaltmaPuani;
                    puanTextBox.Text = Convert.ToString(puan);
                    camListBox.Items.Clear();
                    sayac += 3;
                    camPb.Value = 0;
                }
            }
        }
        //  METAL ATIK KUTUSU BOSALT
        private void metalEmptyButton_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "Metal Kutusu")
            {
                if (metalKutusu.Bosalt())
                {
                    puan += metalKutusu.BosaltmaPuani;
                    puanTextBox.Text = Convert.ToString(puan);
                    metalListBox.Items.Clear();
                    sayac += 3;
                    metalPb.Value = 0;
                }
            }
        }
    }
}
