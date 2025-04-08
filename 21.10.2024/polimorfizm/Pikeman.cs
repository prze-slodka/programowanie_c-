using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    internal class Pikeman : Defender
    {
        // overriding FoodNeeded from abstract class Citizen
        public override int FoodNeeded
        {
            get { return 10; }
        }

        // overriding ReadyToFight from abstract class Defender 
        public override string ReadyToFight()
        {
            return "Pikeman ready to fight!";
        }

        // overriding ToString and adding what was overriden in base (defender)
        public override string ToString()
        {
            return base.ToString() + "pikeman";
        }
    }
}
