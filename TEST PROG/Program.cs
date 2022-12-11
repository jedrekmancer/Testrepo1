using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROG
{
    //Tu deklarujemy klasę
    public class Kot
    {
        internal string imie;
        internal int wiek;

        //Tu jest konstruktor
        //public Kot()
        //{
        //    Console.WriteLine(imie + "spadł z płotu");
        //}


        //Tu maamy zadeklarowaną metodę
        public void Miall()
        {
            Console.WriteLine(imie + "mowi Miallllllll");
        }
        //Tu się kończy metoda

    }
    //Tu się kończy klasa

    internal class Program
    {
        static void Main(string[] args)
        {

            Kot kot1 = new Kot();
            kot1.wiek = 10;
            kot1.imie = "dupek";

            Console.WriteLine("imie " + kot1.imie);
            Console.WriteLine("wiek " + kot1.wiek);
            Console.ReadLine();
            
        }

    }

}
