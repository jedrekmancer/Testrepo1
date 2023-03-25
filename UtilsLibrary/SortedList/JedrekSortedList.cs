using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.SortedList
{
    public class JedrekSortedList
    {
        public List<int> tempList = new List<int>();
        ListItem _begin;    
        public JedrekSortedList()
        {
            _begin = null;
        }




        public void Add(int x)
        {
            if (_begin == null)
            {
                _begin = new ListItem(x);
                tempList.Add(_begin._value);
                return;
            }

            ListItem element = _begin;

            while (element._next != null)
            {
                element = element._next;
                
            }

            element._next = new ListItem(x);
            tempList.Add(element._next._value);




        }

        /*
        public string PrintList(ListItem _begin)
        {
            
            string listInString;
            for (int i = 0; i < ) ;

            foreach (elem in tempList)
            {

            }
            return listInString;
        }
        */
    }
}
