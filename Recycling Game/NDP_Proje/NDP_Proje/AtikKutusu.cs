using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
    //  ATIK KUTUSU IMPLEMENT
    class AtikKutusu : IAtikKutusu
    {
        private string atikKutuAdi;
        private int bosaltmaPuani;
        private int dolulukOrani;
        private int doluHacim = 0;
        private int kapasite;
        //  ATIK KUTUSU KURUCU
        public AtikKutusu(string _atikKutuAdi)
        {
            atikKutuAdi = _atikKutuAdi;
            //  TURLERINE GORE ATAMALAR
            if (_atikKutuAdi == "Organik Atık Kutusu")
            {
                kapasite = 700;
                bosaltmaPuani = 0;
            }
            if (_atikKutuAdi == "Kağıt Kutusu")
            {
                kapasite = 1200;
                bosaltmaPuani = 1000;
            }
            if (_atikKutuAdi == "Cam Kutusu")
            {
                kapasite = 2200;
                bosaltmaPuani = 600;
            }
            if (_atikKutuAdi == "Metal Kutusu")
            {
                kapasite = 2300;
                bosaltmaPuani = 800;
            }
        }

        //  BOSALTMA
        public int BosaltmaPuani
        {
            get
            {
                return bosaltmaPuani;
            }
        }

        //  KAPASITE
        public int Kapasite
        {
            get
            {
                return kapasite;
            }
            set
            {
                Kapasite = value;
            }
        }
        //  DOLULUK ORANI
        public int DolulukOrani
        {
            get
            {
                return dolulukOrani;
            }
        }
        //  DOLU HACIM
        public int DoluHacim
        {
            get
            {
                return doluHacim;
            }
        }
        //  BOSALT FONKSIYONU
        public bool Bosalt()
        {
            //  DOLULUK ORANI KONTROLU
            if (dolulukOrani > 74)
            {
                dolulukOrani = 0;
                doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        //  EKLEME FONKSIYONU
        public bool Ekle(Atik atik)
        {
            // TUR KONTROLU
            if (atik.Tur == "Organik Atık Kutusu")
            {
                //  DOLU MU KONTROL
                if (doluHacim + atik.Hacim <= kapasite)
                {
                    doluHacim = doluHacim + atik.Hacim;
                    dolulukOrani = (doluHacim * 100) / kapasite;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (atik.Tur == "Kağıt Kutusu")
            {
                if (doluHacim + atik.Hacim <= kapasite)
                {
                    doluHacim = doluHacim + atik.Hacim;
                    dolulukOrani = (doluHacim * 100) / kapasite;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (atik.Tur == "Cam Kutusu")
            {
                if (doluHacim + atik.Hacim <= kapasite)
                {
                    doluHacim = doluHacim + atik.Hacim;
                    dolulukOrani = (doluHacim * 100) / kapasite;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (atik.Tur == "Metal Kutusu")
            {
                if (doluHacim + atik.Hacim <= kapasite)
                {
                    doluHacim = doluHacim + atik.Hacim;
                    dolulukOrani = (doluHacim * 100) / kapasite;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
