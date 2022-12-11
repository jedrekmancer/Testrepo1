using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj silnię: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.Write(RecurSilnia(a, a));

            Console.ReadLine();
        }

        public static int RecurSilnia(int silnia, int licznik)
        {
            if (silnia  == 0 || silnia == 1)
            {
                return 1;
            }
            else
            {
                silnia = silnia * (licznik -1);
                licznik--;
                {
                    if (licznik == 0)
                    {
                        return silnia;
                    }
                    else
                    {
                        RecurSilnia(silnia, licznik);
                    }
                }
            
            }
            
        }

    }
    
   

}
