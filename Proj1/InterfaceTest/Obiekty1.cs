using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1.InterfaceTest
{
    internal class Obiekty1 : ITest
    {
        private string _title;
        
        private int _count;

        public Obiekty1(string title, int count)
        {
            _title = title;
            _count = count;
        }

        public string GetTitle()
        {
            return _title;
        }

        public int GetCount()
    {
            return _count;
        }
    }
}
