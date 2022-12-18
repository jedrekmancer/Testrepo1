using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodzielLiczby100Rekurencja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Program sprawdza podzielność liczb przez 2, 3 i 4");
            Console.Write("Podaj liczbę od 0 do 100: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoja liczba to " + a);
            Check.CheckDivid(a);

            Console.ReadLine();


        }

        public class Check
        {
            public const int f = 100;
            public static void CheckDivid(int s)
            {
                if (s > f)
                {
                    Console.WriteLine("Kuniec");
                }
                else if (s % 2 == 0)
                {
                    if (s % 4 == 0)
                    {
                        Console.WriteLine(s + " - podzielna przez 2 i 4");
                        CheckDivid(s + 1);
                    }
                    else
                    {
                        Console.WriteLine(s + " - podzielna przez 2");
                        CheckDivid(s + 1);
                    }
                }
                else if (s % 3 == 0)
                {
                    Console.WriteLine(s + " - podzielna przez 3");
                    CheckDivid(s + 1);
                }

                else
                {
                    Console.WriteLine(s);
                    CheckDivid(s + 1);

                }

            }
        }


    }



}

