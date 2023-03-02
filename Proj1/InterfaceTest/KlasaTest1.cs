using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class KlasaTest1
    {
        List<ITest> _tests = new List<ITest>();

        public void AddObject(ITest objectToAdd)
        {
            _tests.Add(objectToAdd);
        }

        public List<string> nazwyObiektow()
        {
            List<string> wszystkieObiekty = new List<string>();
            foreach (ITest obiektW_tests in _tests)
            {
                wszystkieObiekty.Add(obiektW_tests.GetTitle());
            }
            return wszystkieObiekty;
        }

        public int IleWKlasie()
        {
            return _tests.Count;
        }

    }
}
