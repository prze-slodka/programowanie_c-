using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    abstract class Citizen
    {
        // variable that will be overriden by subclass
        abstract public int FoodNeeded { get; }

        // method for returning FoodNeeded that will be overriden by subclass
        public int Eat() 
        {
            return FoodNeeded;
        }
    }
}
