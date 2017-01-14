using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Skladnik : IComparable<Skladnik>, ICloneable
    {
        public Skladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            if (cenaSkladnika >= 7)
            {
                throw new Exception("Cena ma byc mniejsza niz 7");
            }
            if (cenaSkladnika < 0)
            {
                throw new Exception("Cena nie może być ujemna.");
            }
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }
        private string nazwaSkladnika;
        private double cenaSkladnika;

        public override string ToString()
        {
            return string.Format("Nazwa: {0}, cena: {1}",nazwaSkladnika,cenaSkladnika);
        }

        public string GetNazwaSkladnika()
        {
            return nazwaSkladnika;
        }

        public double GetCenaSkladnika()
        {
            return cenaSkladnika;
        }

        public int CompareTo(Skladnik other)
        {
            var firstComparison = cenaSkladnika.CompareTo(other.GetCenaSkladnika());
            if (firstComparison == 0)
            {
                return nazwaSkladnika.CompareTo(other.GetNazwaSkladnika());
            }
            return firstComparison;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
