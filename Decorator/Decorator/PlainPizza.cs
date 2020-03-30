using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PlainPizza : Pizza
    {
        public double getCost()
        {
            Console.WriteLine("From plain");
            return 4.00;
        }

        public string getDescription()
        {
            return "Thin Dough";
        }
    }
}
