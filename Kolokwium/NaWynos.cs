using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class NaWynos : Zamowienie
    {
        public NaWynos(string czasDostawy = null)
            : base(czasDostawy)
        {

        }
        public override bool PoprawnyCzas()
        {
            if (czasDostawy == "dzis")
            {
                return true;
            }
            return false;
        }
    }
}
