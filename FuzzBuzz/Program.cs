using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FuzzBuzz v1.0 by jedrekmancer");
            int r3;
            int r5;

            for (int i = 1; i <= 100; i++)
            {
                r3 = i % 3;
                r5 = i % 5;

                if (r3 == 0)
                {
                    Console.Write(i);
                    Console.Write(" Fuzz");

                    if (r5 == 0)
                    {
                        Console.WriteLine(" Buzz");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                 if (r5 == 0)
                    {
                        Console.Write(i);
                        Console.WriteLine(" Buzz");
                    }
                    
                }

            }
            Console.ReadLine();





        }
    }
}
