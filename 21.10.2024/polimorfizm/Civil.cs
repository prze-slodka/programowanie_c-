using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    internal class Civil : Citizen
    {
        // overriding FoodNeeded from abstract class Citizen
        public override int FoodNeeded
        {
            get
            {
                return 1;
            }
        }

        // overriding ToString
        public override string ToString()
        {
            return "civil";
        }
    }
}
