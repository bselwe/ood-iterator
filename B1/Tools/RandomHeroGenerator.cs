using Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Tools
{
    class RandomHeroGenerator
    {
        private static int id = 0;

        public Hero GenerateRandomHero()
        {
            Random rnd = new Random(id);
            int mana = rnd.Next(0, 200);
            int hp = rnd.Next(50, 1000);
            int lvl = rnd.Next(1, 100);

            Array values = Enum.GetValues(typeof(HeroClass));
            HeroClass heroClass = (HeroClass)values.GetValue(rnd.Next(values.Length));

            int nMinions = heroClass == HeroClass.Warrior || heroClass == HeroClass.Paladin ? 0 : rnd.Next(0, 4);

            values = Enum.GetValues(typeof(WeaponType));
            WeaponType weapon = (WeaponType)values.GetValue(rnd.Next(0, values.Length));

            values = Enum.GetValues(typeof(Race));
            Race race = (Race)values.GetValue(rnd.Next(0, values.Length));

            String title = "";
            int temp = rnd.Next(0, 100);
            if(temp > 80)
            {
                title = "Kingslayer";
            }
            else if(temp > 60)
            {
                title = "Sir";
            }
            Hero result = new Hero(id++, heroClass, race, names[rnd.Next(0, names.Length)]);
            result.Mana = mana;
            result.Hp = hp;
            result.Lvl = lvl;
            result.NMinions = nMinions;
            result.Weapon = weapon;
            result.Title = title;

            return result;
        }

        static String[] names =
        {
            "Aluuine Filipov",
            "Nott Wendt",
            "Aelfraed Tsoutsouvas",
            "Waldive Garza",
            "Txilar Emory",
            "Uwen Santon",
            "Aristandros Steigauf",
            "Astorge Mouritse",
            "Sibragtus Lelouch",
            "Théodard Dehaene",
            "Balcan",
            "Yinxalim",
            "Zumhorn",
            "Qinvalur",
            "Mirasalor",
            "Keavalur",
            "Paceran",
            "Balro"
        };
    }
}
