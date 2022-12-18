using Proj1.InterfaceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaTest1 x = new KlasaTest1();
            KlasaTest1 y = new KlasaTest1();

            Obiekty1 x1 = new Obiekty1("xxaaa", 1);
            x.AddObject(x1);
            Obiekty1 x2 = new Obiekty1("xxbbb", 2);
            x.AddObject(x2);
            Obiekty1 y1 = new Obiekty1("yyaaa", 11);
            y.AddObject(y1);
            Obiekty1 y2 = new Obiekty1("yybbb", 22);
            y.AddObject(y2);
            Obiekty1 y3 = new Obiekty1("yyccc", 33);
            y.AddObject(y2);
            WywalNazwyObiektow(x);
            WywalNazwyObiektow(y);
            WywalNazwyObiektow(x);
            

            //Console.WriteLine(x.IleWKlasie());
            //Console.WriteLine(y.IleWKlasie());
            //Console.WriteLine(x1.GetTitle());
            //Console.WriteLine(x2.GetTitle());
            //Console.WriteLine(y1.GetTitle());
            //Console.WriteLine(y2.GetTitle());


            Console.ReadKey();
        }

        private static void WywalNazwyObiektow(KlasaTest1 x)
        {
            foreach (string a in x.nazwyObiektow())

            {
                Console.WriteLine(a);
            }
        }
    }
}
