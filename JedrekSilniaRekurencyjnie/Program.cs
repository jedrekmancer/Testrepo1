using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilniaUtils;

namespace JedrekSilniaRekurencyjnie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Program wyświetla silnię z podanej liczby");
            Console.Write("Podaj swoją liczbę: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoja liczba to {0}", a);
            Console.WriteLine("Silnia !{0} wynosi: {1}",a , SilniaClass.Silnia(a));

            Console.ReadLine();
        }

    }



}
