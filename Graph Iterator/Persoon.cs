using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Iterator
{
    class Persoon
    {
        public List<Persoon> vrienden = new List<Persoon>();
        public string naam;

        public Persoon(string naam)
        {
            this.naam = naam;
        }

        public void addFriend(Persoon persoon)
        {
            if(!vrienden.Any(p => p == persoon))
            {
                vrienden.Add(persoon);
            }

            if (!persoon.vrienden.Any(p => p == this))
            {
                persoon.addFriend(this);
            }
        }
    }
}
