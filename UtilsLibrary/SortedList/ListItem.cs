using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.SortedList
{
    internal class ListItem
    {
        public int _value { get; set; }

        public ListItem _next;

        public ListItem(int value)
        {
            _value = value;
            _next = null;
        }
    }
}
