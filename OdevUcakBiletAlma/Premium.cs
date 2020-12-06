using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevUcakBiletAlma
{
    class Premium : Bilet
    {

        string _ekstra = "Ekstra 10 Kg Bagaj Hakkı ve Ücretsiz Servis";

        public string Ekstra { get { return _ekstra; } }

        public override double Hesap(int t)
        {
            return base.Hesap(110);
        }

    }
}
