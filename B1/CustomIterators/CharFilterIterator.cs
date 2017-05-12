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
    class CharFilterIterator : IEnumerable<Hero>
    {
        private ICustomCollection<Hero> list = null;
        private char c;

        public CharFilterIterator(ICustomCollection<Hero> list, char c)
        {
            this.list = list;
            this.c = c;
        }

        public IEnumerator<Hero> GetEnumerator()
        {
            for (int i = 0; i < list.Size; i++)
            {
                Hero hero = list.Get(i);
                string heroName = hero.HeroName;
                if (!String.IsNullOrEmpty(heroName) && heroName[0] == c)
                    yield return hero;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
