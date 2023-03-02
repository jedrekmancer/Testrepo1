using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClassInterfEtc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Obiekty1> listaob1 = new List<Obiekty1>();
            int obiektCounter = 1;
            int wiekObiektu;
            StartFunction();

            while (true)
            {
                Console.Write("Podaj nazwę obiektu numer " + obiektCounter + " (zakończ -x-, sprawdz -s-) : ");
                string podajNazwe = Console.ReadLine();
                if (podajNazwe[0] == 'x')
                {
                    Console.WriteLine("Wracamy na początek");
                    StartFunction();
                }
                else if (podajNazwe[0] == 's')
                {
                    Console.WriteLine("Oto lista obiektów: ");
                    for (int i = 0; i < listaob1.Count; i++)
                    {
                        Console.WriteLine("Obiekt nr " + listaob1[i].GetNr() + " ma nazwę: " + listaob1[i].GetName() + " i ma wiek: " + listaob1[i].GetAge());
                    }
                    Console.WriteLine("I tyle...PA");
                    StartFunction();
                }
                else
                {
                    Console.Write("Podaj wiek obiektu: ");
                    wiekObiektu = Convert.ToInt32(Console.ReadLine());
                    listaob1.Add(new Obiekty1(podajNazwe, wiekObiektu, obiektCounter));
                    obiektCounter++;

                }



            }


        }

        private static void StartFunction()
        {
            while (true)
            {
                Console.Write("Chcesz zrobić sobie obiekt (t/n) ? ");
                string w = Convert.ToString(Console.ReadLine()[0]);

                if (w == "t")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("To spadaj, bo ten program służy robieniu obiektów");
                    continue;
                }

            }
        }

        public static void PokazCos(Obiekty1 x)
        {
            Console.WriteLine("Nazwa obiektu to: " + x._nazwaob);
        }



    }
    interface ITest
    {
        string GetName();

        int GetAge();
    }


    public class Obiekty1 : ITest
    {
        public int _nrObiektu;
        public string _nazwaob;
        public int _wiekob;
        public int _liczbaAllDodOb = 0;
        public Obiekty1(string nazwaob, int wiekob, int nrOb)
        {
            _nazwaob = nazwaob;
            _wiekob = wiekob;
            _liczbaAllDodOb++;
            _nrObiektu = nrOb;
        }

        public int GetNr()
        {
            return _nrObiektu;
        }

        public string GetName()
        {
            return _nazwaob;
        }

        public int GetAge()
        {
            return _wiekob;
        }

        public int GetTotalNumber()
        {
            return _liczbaAllDodOb;
        }
    }

}
