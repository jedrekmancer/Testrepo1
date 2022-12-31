using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dupaąeę");
            DateTime data1 = new DateTime(2022, 8, 28);
            Console.WriteLine(data1);
            int mynum = data1.Year;
            Console.WriteLine(mynum);
            int munum2 = data1.Month;
            Console.WriteLine(munum2);
            int mynum3 = data1.Day;
            Console.WriteLine(mynum3);
            Console.WriteLine();

            Console.WriteLine(data1.ToString("dd.MM.yyyy"));


            DateTime thisDate1 = new DateTime(2011, 6, 10);
            Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
                                                          TimeSpan.Zero);
            Console.WriteLine("The current date and time: {0:MM/dd/yy H:mm:ss zzz}",
                               thisDate2);

            Console.WriteLine();
            DateTime start = DateTime.Now;
            Console.WriteLine(start);
            Person osoba1;
            osoba1.age = 10;

            Console.WriteLine(osoba1.age);
            Console.WriteLine();
            List<string> listA = new List<string> { "a", "b", "c" };
            Console.WriteLine("dodalem do A" + listA.Count);
            List<string> listB = new List<string> { "d", "e", "f" };
            foreach (string a in listA) Console.WriteLine(a);
            foreach (string a in listB) Console.WriteLine(a);
            listA.Add(null);
            Console.WriteLine("null dodany i" + (listA.Count));


            Console.WriteLine(listA.Count + listB.Count);
            listA.Add(null);
            listA.Add(null);
            listA.AddRange(listB);
            
            foreach (string a in listA) Console.WriteLine(a);
            Console.WriteLine("i teraz jest lacznie" + (listA.Count));



            Console.ReadLine();
        }
        struct Person
        {
            public string name;
            public int age;
        }

        enum Miesiace
        {
            Styczen,
            Luty,
            Marzec,
            Kwiecien,
            Maj,
            Czerwiec,
            Lipiec,
            Sierpien,
            Wrzesien,
            Pazrdziernik,
            Listopad,
            Grudzien

        }


    }

}
