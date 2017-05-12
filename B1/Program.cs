
using Game;
using Game.CustomCollections;
using Game.CustomIterators;
using Game.Model;
using Game.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<Hero> zone1List = generateZone1();
            ICustomCollection<Hero> zone2List = generateZone2();
            ICustomCollection<Hero> zone3List = generateZone3();

            IEnumerable<Hero> zone1Iterator = new ListIterator(zone1List),
                zone2Iterator = new ListIterator(zone2List),
                zone3Iterator = new ListIterator(zone3List);

            IEnumerable<Hero> zone1FilterIterator = new CharFilterIterator(zone1List, 'S'),
              zone2FilterIterator = new CharFilterIterator(zone2List, 'B'),
              zone3FilterIterator = new CharFilterIterator(zone3List, 'A');
            
            DisplayZones(zone1Iterator, zone2Iterator, zone3Iterator);
            Console.WriteLine(Environment.NewLine);
            
            DisplayVariations(zone1Iterator, zone2Iterator, zone3Iterator);
            Console.WriteLine(Environment.NewLine);
            
            DisplayZones(zone1FilterIterator, zone2FilterIterator, zone3FilterIterator);
            Console.WriteLine(Environment.NewLine);

            DisplayVariations(zone1FilterIterator, zone2FilterIterator, zone3FilterIterator);
        }

        private static void DisplayZones(params IEnumerable<Hero>[] iterators)
        {
            Console.WriteLine("Zones");
            for (int i = 0; i < iterators.Length; i++)
            {
                Console.WriteLine($"Zone {i+1}");
                foreach (Hero h in iterators[i])
                    Console.WriteLine(h.ToString());
            }
        }

        private static void DisplayVariations(params IEnumerable<Hero>[] iterators)
        {
            Console.WriteLine("Variations");
            for (int i = 0; i < iterators.Length; i++)
            {
                foreach (Hero h1 in iterators[i])
                {
                    for (int j = 0; j < iterators.Length; j++)
                    {
                        foreach (Hero h2 in iterators[j])
                        {
                            Console.WriteLine($"{h1.Id} {h2.Id}");
                        }
                    }
                }
            }
            
        }
        
        // DO NOT CHANGE CODE BELOW
        static ICustomCollection<Hero> generateZone1()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for(int i=0; i<20; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone2()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone3()
        {
            ReversedArrayList<Hero> result = new ReversedArrayList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }
    }
}
