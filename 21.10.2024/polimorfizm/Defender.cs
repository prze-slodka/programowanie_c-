using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    abstract class Defender : Citizen
    {
       
        // method for returning ReadyText that will be overriden by subclass
        public virtual string ReadyToFight() 
        {
            return "mumbles something in defenders";
        }
        
        // overriding ToString
        public override string ToString()
        {
            return "defender/";
        }


    }
}
