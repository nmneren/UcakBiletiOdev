using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OdevUcakBiletAlma
{
    class Bilet
    {
        int _kisisayisi;
        public int KisiSayisi { get { return _kisisayisi; } set { _kisisayisi = value; } }

        public virtual double Hesap(int tutar)
        {
            return tutar * _kisisayisi;
        }
    }
}
