using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("b " + b);
                a = b * (b =  b + 1); 
                
                Console.WriteLine("a " + a);
                
            }

            Console.ReadLine();
        }
    }
}
