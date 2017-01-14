using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Sos : Skladnik
    {
        
        public string NazwaSosu;
        public double CenaSosu;

        public Sos(string nazwaSosu,double cenaSosu) : base(nazwaSosu,cenaSosu)
        {
            NazwaSosu = nazwaSosu;
            CenaSosu = cenaSosu;
        }

        public override string ToString()
        {
            return string.Format("Sos: {0}, cena: {1}", NazwaSosu, CenaSosu);
        }
    }
}
