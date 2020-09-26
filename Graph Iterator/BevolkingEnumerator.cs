using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Iterator
{
    class BevolkingEnumerator : IEnumerator<Persoon>
    {
        private List<Persoon> _iteratedOver;
        private Persoon _iteratorOf;

        private bool hasCurrentBeenSelf = false;

        private IEnumerator<Persoon> _enumerator;

        public Persoon Current
        {
            get
            {
                if (_enumerator != null) return _enumerator.Current;
                else return _iteratorOf;
            }
        }

        object IEnumerator.Current => Current;


        public BevolkingEnumerator(Persoon iteratorOf, List<Persoon> iteratedOver)
        {
            _iteratorOf = iteratorOf;
            _iteratedOver = iteratedOver;

            _iteratedOver.Add(_iteratorOf);
        }

        public BevolkingEnumerator(Persoon iteratorOf) : this(iteratorOf, new List<Persoon>()) { }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(!hasCurrentBeenSelf)
            {
                hasCurrentBeenSelf = true;
                return true;
            }
            
            if(_enumerator == null || !_enumerator.MoveNext())
            {
                Persoon next = _iteratorOf.vrienden.FirstOrDefault(p => !_iteratedOver.Any(p2 => p == p2));
                if (next == null) return false;
                else { 
                    _enumerator = new BevolkingEnumerator(next, _iteratedOver);
                    _enumerator.MoveNext();
                }
            }

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
