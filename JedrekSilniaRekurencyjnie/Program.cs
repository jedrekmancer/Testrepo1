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
            Console.WriteLine("Program wyświetla silnię z podanej liczby");
            Console.Write("Podaj swoją liczbę: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoja liczba to " + a);
            Console.WriteLine("Silnia !" + a + " wynosi: " + SilniaUtils.SilniaClass.Silnia(a));

            Console.ReadLine();
        }

    }



}
