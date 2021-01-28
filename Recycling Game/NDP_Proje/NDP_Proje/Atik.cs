using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
    //  IATIK INTERFACE IMPLEMENTS
    public class Atik : IAtik
    {
        //  PRIVATE DEGISKENLER
        private string ad;
        private Image image;
        private int hacim;
        private string tur;
        //  HACIM TANIMLAMASI
        public int Hacim
        {
            get
            {
                return hacim;
            }
        }

        //  IMAGE TANIMLANMASI
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
        //  AD VE TUR SET GET
        public string Ad { get => ad; set => ad = value; }
        public string Tur { get => tur; set => tur = value; }
        //  ATIK KURUCU
        public Atik()
        {
            //  ATIK ADLARI DIZI
            string[] atikAdlar = { "Cam Şise", "Bardak", "Gazete", "Dergi", "Domates", "Salatalık", "Kola Kutusu", "Salça Kutusu" };
            //  RASTGEL SAYI OLUSTUR
            Random rnd = new Random();
            string tempAd = atikAdlar[rnd.Next(0, 7)];

            //  OLUSTURULAN CAM SISE ISE
            if (tempAd == "Cam Şise")
            {
                Ad = tempAd;
                Tur = "Cam Kutusu";
                hacim = 600;
                image = Image.FromFile("cam-sise.png");
            }
            //  OLUSTURULAN BARDAK ISE
            if (tempAd == "Bardak")
            {
                Ad = tempAd;
                Tur = "Cam Kutusu";
                hacim = 250;
                image = Image.FromFile("bardak.jpg");
            }
            //  OLUSTURULAN GAZETE ISE
            if (tempAd == "Gazete")
            {
                Ad = tempAd;
                Tur = "Kağıt Kutusu";
                hacim = 250;
                image = Image.FromFile("gazete.png");
            }
            //  OLUSTURULAN DERGI ISE
            if (tempAd == "Dergi")
            {
                Ad = tempAd;
                Tur = "Kağıt Kutusu";
                hacim = 200;
                image = Image.FromFile("dergi.png");
            }
            //  OLUSTURULAN DOMATES ISE
            if (tempAd == "Domates")
            {
                Ad = tempAd;
                Tur = "Organik Atık Kutusu";
                hacim = 150;
                image = Image.FromFile("domates.png");
            }
            //  OLUSTURULAN SALATALIK ISE
            if (tempAd == "Salatalık")
            {
                Ad = tempAd;
                Tur = "Organik Atık Kutusu";
                hacim = 120;
                image = Image.FromFile("salatalık.png");
            }
            //  OLUSTURULAN KOLA KUTUSU ISE
            if (tempAd == "Kola Kutusu")
            {
                Ad = tempAd;
                Tur = "Metal Kutusu";
                hacim = 350;
                image = Image.FromFile("kutu-kola.png");
            }
            //  //  OLUSTURULAN SALCA KUTUSU ISE
            if (tempAd == "Salça Kutusu")
            {
                Ad = tempAd;
                Tur = "Metal Kutusu";
                hacim = 550;
                image = Image.FromFile("salça.png");
            }
        }
    }
}
