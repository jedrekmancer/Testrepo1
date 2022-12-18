using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program -Drzewo rekurencyjnie-");
            Console.Write("Podaj znak: ");
            char znak = Convert.ToChar(Console.ReadLine()[0]);
            Console.Write("Podaj podstawę (liczba nieparzysta): ");
            int podstawa;
            while (true)
            {
                podstawa = Convert.ToInt32(Console.ReadLine());
                if (podstawa % 2 == 0)
                {
                    Console.Write("Podaj liczbę nieparzystą: ");
                    continue;
                }
                else break;
            }
            
            TreeBuilder Tree1 = new TreeBuilder();
            Tree1.RTree(znak, podstawa);

            Console.ReadLine();
        }
        
    }
    public class TreeBuilder
    {
        public int _znk = 1;
        public int _polowapodst;
        public void RTree(char znak, int podstawa)
        {
            _polowapodst = podstawa / 2;

            if (podstawa < 1)
            {
                Console.WriteLine("KuniecDrzewa");
            }
            else
            { 
            Linia(_polowapodst, _znk, znak);
            _znk += 2;
            RTree(znak, podstawa - 2);
            }

        }

        public void Znaki(int lzn,char znk)
        {
            if (lzn == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(znk);
                Znaki(lzn - 1, znk);
            }

        }
        public void Linia(int s,int zn, char znak)
        {
            if (s == 0)
            {
                Znaki(zn, znak);
                return;
            }
            else
            {
                Console.Write(" ");
                Linia(s - 1, zn, znak);
            }
            
              

        }



    }

}
