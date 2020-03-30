using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new Item { name = "Item1" };
            collection[1] = new Item { name = "Item2" };
            collection[2] = new Item { name = "Item3" };
            collection[3] = new Item { name = "Item4" };
            collection[4] = new Item { name = "Item5" };
            collection[5] = new Item { name = "Item6" };
            collection[6] = new Item { name = "Item7" };
            collection[7] = new Item { name = "Item8" };
            collection[8] = new Item { name = "Item9" };

            // Create iterator

            Iterator iterator = collection.CreateIterator();

            // Skip every other item

            iterator.Step = 1;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.name);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
