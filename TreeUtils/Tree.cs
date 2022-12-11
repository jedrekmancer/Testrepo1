using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUtils
{
    public class Tree
    {
        private string sign;
        private int baseWidth;
        private int lKloc = 1;

        public Tree(string _sign, int _baseWidth)
        {
            sign = _sign;
            baseWidth = _baseWidth;
            for (int i = 1; i >= 1; i = i - 2)
            {
                for (int s1 = 1; s1 <= spac0; s1)
                PrintSpac(i);
                PrintKloc(sign);
                




            }

        }


        private void PrintSpac(int lSpac)
        {
            string spac = " ";
            lSpac = ((baseWidth + 1) / 2) - 1;
            for (int i = baseWidth; i >= 1; i = i - 2)
            {
                PrintSymb(spac, lSpac);
            }

        }

        private void PrintKloc(string kloc)
        {
            kloc = sign;
            for (int i = baseWidth; i >= 1; i = i - 2)
            {
                PrintSymb(kloc, lKloc);
            }

        }

        private void PrintSymb(string symb, int lSymb)
        {
            for (int i = 0; i <= lSymb; i++)
            {
                Console.Write(symb);
            }
        }

    }


}
