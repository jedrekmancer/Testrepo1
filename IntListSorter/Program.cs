using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.SortedList;
namespace IntListSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            int value;
            JedrekSortedList Lista1 = new JedrekSortedList();
            Console.WriteLine("Podaj inta lub x aby zakończyć");

            while (true)
            {
                inputValue = Console.ReadLine();
                if (int.TryParse(inputValue, out value))
                {
                    Lista1.Add(value);

                }
                else if (inputValue == "x")
                    break;
                else
                    Console.WriteLine("Zła wartość...");
            }

            // Console.WriteLine(Lista1.PrintList());
            foreach (var item in Lista1.tempList)
            { Console.Write($" -> {item}"); }
            Console.WriteLine("Pa!");
            Console.ReadLine();
        }
    }
}
