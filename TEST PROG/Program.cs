using System;
using System.Collections;
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
            Animal anim1 = new Animal("anim11");
            Animal anim2 = new Mammal("Mammal referenced by Animal", "namefor anim mammal22 ");
            Mammal mammal1 = new Mammal("Mammal ref as Mammal", "name for mam mam333");

            anim1.Ident();
            anim2.Ident();
            Console.WriteLine(anim2._name);
            anim2.Ident();
            mammal1.Ident();



            Console.ReadLine();
        }
    }


    public class Animal
    {
        public string _name;

        //public Animal()
        //{
        //    Console.WriteLine("Animal w/o parameter");
        //}
        public Animal(string name)
        {
            _name = name;
        }

        public void Ident()
        {
            Console.Write($"Nazwa Animala: {_name}");
        }

    }

    public class Mammal : Animal
    {
        public string _name;

        public Mammal(string name, string nameforanimal) : base(nameforanimal)
        {
            _name = name;
        }

        public void Ident()
        {
            Console.Write($"Nazwa mammala: {_name}");
        }

    }




}








