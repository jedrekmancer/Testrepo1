using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedrekFibonacciRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("JedrekFibonacciRecursion");
            Console.WriteLine("Program wyświetla ciąg Fibonacciego do podanej liczby (wykorzystując mechanizm rekurencji)");
            Console.Write("Podaj ile liczb ciągu Fibonacciego chcesz wyświetlić: ");
            
            int argument;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out argument))
                {
                    if (argument <= 0)
                    {
                        Console.Write("Podaj liczbę całkowitą większą od 0: ");
                        continue;
                    }
                    break;
                }
                Console.Write("Podaj liczbę całkowitą większą od 0: ");
            }
            Console.Write("Oto twój ciąg Fibonaciego: ");
            FibonRecurs(1, 0, 1, argument);
            
            
            
            Console.ReadLine();
        }

        public static void FibonRecurs(int a, int b, int c, int loopAmount)
        {
            if (loopAmount == 0)
            {
                return;
            }
            else
            {
                a = b;
                b = c;
                c += a;
                Console.Write($"{c} ");
                FibonRecurs(a, b, c, loopAmount - 1);
            }
        }




    }

}
