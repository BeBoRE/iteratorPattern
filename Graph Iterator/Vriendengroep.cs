using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Iterator
{
    class Vriendengroep : IEnumerable<Persoon>
    {
        private Persoon start;

        public Vriendengroep(Persoon start)
        {
            this.start = start;
        }

        public IEnumerator<Persoon> GetEnumerator()
        {
            return new VriendengroepEnumerator(start);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
