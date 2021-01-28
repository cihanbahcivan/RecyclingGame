using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
    //  IATIKKUTUSU INTERFACE TANIMLAMA
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }
        bool Ekle(Atik atik);
        bool Bosalt();
    }
}
