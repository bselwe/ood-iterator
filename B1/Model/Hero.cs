using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    class Hero
    {
        private readonly string _heroName;
        private readonly HeroClass _hClass;
        private readonly Race _race;
        private readonly int id;

        public int Hp { get; set; }
        public int Mana { get; set; }
        public int Lvl { get; set; }
        public WeaponType Weapon { get; set; }
        public int NMinions { get; set; }
        public string Title { get; set; }


        public Hero(int id, HeroClass heroClass, Race race, string heroName)
        {
            this.id = id;
            this._hClass = heroClass;
            this._race = race;
            this._heroName = heroName;
        }

        public override string ToString()
        {

            return id + " " + (Title.Length == 0 ? "" : (Title + " ")) + _heroName + " " + _hClass + " " + _race + " (hp = " + Hp + "; mana = " + Mana + ";)";
        }


        public string HeroName
        {
            get
            {
                return _heroName;
            }
        }

        public HeroClass HeroClass
        {
            get
            {
                return _hClass;
            }
        }

        public Race Race
        {
            get
            {
                return _race;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

    }
}
