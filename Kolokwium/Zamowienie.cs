using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class Zamowienie
    {
        protected string czasDostawy;

        public Zamowienie(string czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }

        public void UstawCzasDostawy(string czasDostawy)
        {
            this.czasDostawy = czasDostawy;
        }

        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy != null && czasDostawy != "wczoraj")
            {
                return true;
            }
            return false;
        }
    }
}
