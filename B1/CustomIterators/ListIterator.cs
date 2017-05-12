using Game.CustomCollections;
using Game.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomIterators
{
    class ListIterator : IEnumerable<Hero>
    {
        private ICustomCollection<Hero> list = null;

        public ListIterator(ICustomCollection<Hero> list)
        {
            this.list = list;
        }

        public IEnumerator<Hero> GetEnumerator()
        {
            for (int i = 0; i < list.Size; i++)
                yield return list.Get(i);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
