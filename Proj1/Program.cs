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
            int a;
            Console.Write("Podaj silnię: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            
            
            Console.Write(RecurSilnia(a));

            Console.ReadLine();
        }

        public static int RecurSilnia(int b)
        {
            int silnia;
            if (b == 0 || b == 1)
            {
                return 1;
            }
            else
            {
                silnia = b * (b = b - 1);
                Console.WriteLine(b);
                Console.WriteLine(silnia);
                return RecurSilnia(b);a
            
            }
            
        }

    }
    
   

}
