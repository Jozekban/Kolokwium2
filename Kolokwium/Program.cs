using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new List<Skladnik>();
            var items = new List<KeyValuePair<string,double>>();
            items.Add(new KeyValuePair<string,double>("ser", 3.81));
            items.Add(new KeyValuePair<string, double>("oliwki", 3.81));
            items.Add(new KeyValuePair<string,double>("salami", -2.5));
            items.Add(new KeyValuePair<string,double>("ciasto", 7.14));
            items.Add(new KeyValuePair<string,double>("keczup", 2.54));
            foreach (var item in items)
	        {
		        try
                {
                    pizza.Add(new Skladnik(item.Key,item.Value));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
	        }
            
            
            pizza.Sort();
            pizza.Reverse();
            pizza.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine(string.Format("Suma cen składników: {0}",pizza.Sum( item => item.GetCenaSkladnika())));

            ////////////////////////////////////////////////

            var kolejka = new Queue<Zamowienie>();
            kolejka.Enqueue(new NaMiejscu("wczoraj"));
            kolejka.Enqueue(new NaMiejscu());
            kolejka.Enqueue(new NaMiejscu("dzis"));
            kolejka.Enqueue(new NaWynos());
            kolejka.Enqueue(new NaWynos("dzis"));

            foreach (var item in kolejka)
            {
                Console.WriteLine(item.PoprawnyCzas());
            }

            while (kolejka.Count != 0)
            {
                kolejka.Dequeue();
            }

            ////////////////////////////////////////////////

            var pizza2 = new ArrayList();

            pizza2.Add(new Skladnik("salami", 3.81));
            pizza2.Add(new Skladnik("oliwki", 3.81));
            pizza2.Add(new Skladnik("ciasto", 4.14));
            pizza2.Add(new Sos("pomidorowy", 2.53));
            pizza2.Add(new Sos("śmietanowy", 1.27));
            pizza2.Add(new Sos("pesto", 6.89));

            
            foreach (var item in pizza2)
            {
                Console.WriteLine(item.ToString());		 
            }
            var pizza2Array = pizza2.ToArray().Cast<Skladnik>();

            Console.WriteLine("Suma cen skladnikow: {0}", pizza2Array.Sum(item => item.GetCenaSkladnika()));

            var skladnik = pizza2Array.FirstOrDefault();
            pizza2.Add(skladnik.Clone());

            foreach (var item in pizza2)
            {
                Console.WriteLine(item.ToString());
            }

            pizza2.Clear();
            pizza2Array = null;

            Console.ReadLine();
        }
    }
}
