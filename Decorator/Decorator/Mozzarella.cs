using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");
            Console.WriteLine("Adding Mozzerella");
        }

        public override double getCost()
        {
            Console.WriteLine("From Mozz");
            return tempPizza.getCost() + .50;
        }

        public override string getDescription()
        {
            return tempPizza.getDescription() + ", Mozzarella";
        }
    }
}
