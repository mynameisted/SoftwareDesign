using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TomatoSauce : ToppingDecorator
    {
      
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
          
        }

        public override double getCost()
        {
            Console.WriteLine("From tomata");
            return tempPizza.getCost() + 0.25;
        }

        public override string getDescription()
        {
            return tempPizza.getDescription() + ", Tomato Sauce";
        }
    }
}
