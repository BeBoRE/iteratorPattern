using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Iterator
{
    class Bevolking : IEnumerable<Persoon>
    {
        private Persoon start;

        public Bevolking(Persoon start)
        {
            this.start = start;
        }

        public IEnumerator<Persoon> GetEnumerator()
        {
            return new BevolkingEnumerator(start);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
