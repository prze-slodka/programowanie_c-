using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    public class HumanOnMS
    {
        
        public int Beer_Amount { get; }
        public string Beer_Name { get; set; }

        public HumanOnMS(string beer_name)
        {
            Random rnd = new Random();
            Beer_Amount = rnd.Next(1, 13);
            Beer_Name = beer_name;

        }

        
    }
}
