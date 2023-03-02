using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedrekFibonacciRecursion
{
    internal static class FibonacciClass
    {

        public static int UserInputCheck(string argument)
        {
            while (true)
            {
                if (Int32.TryParse(argument, out int output) == false || output <= 0)
                {
                    Console.Write("Podaj liczbę całkowitą większą od 0: ");
                    UserInputCheck(Console.ReadLine());
                }
                return output;
            }
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
