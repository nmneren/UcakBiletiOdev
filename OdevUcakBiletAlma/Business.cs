using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevUcakBiletAlma
{
    class Business : Bilet
    {

        string _ekstra = "Ekstra 50 Kg Bagaj Hakkı, Ücretsiz Servis ve Havalimanında Ücretsiz Yemek.";

        public string Ekstra { get { return _ekstra; } }

        public override double Hesap(int t)
        {
            return base.Hesap(140);
        }

    }
}
