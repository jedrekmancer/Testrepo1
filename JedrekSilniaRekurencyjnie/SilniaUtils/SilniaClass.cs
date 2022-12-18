using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1.SilniaUtils
{
    public class SilniaClass
    {
        public static int Silnia(int s)
        {
            if (s == 0)
            {
                return 1;
            }
            else
            {
                return s * (Silnia(s - 1));
            }
        }


    }
}
