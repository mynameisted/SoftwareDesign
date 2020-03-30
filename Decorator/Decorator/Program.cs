using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine("Ingredients: " + basicPizza.getDescription());

            Console.WriteLine("Cost: " + basicPizza.getCost());
        }
    }
}
