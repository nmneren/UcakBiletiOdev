using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevUcakBiletAlma
{
    class Ekonomi : Bilet
    {
        public override double Hesap(int t)
        {
            return base.Hesap(90);
        }


    }
}
