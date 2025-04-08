using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDomowe;

namespace ZadanieDomowe
{
    public class Worker : HumanOnMS
    {
        public int Efficiency { get; }

        public Worker(string beer_name) : base (beer_name)
        {
            Efficiency = (Beer_Amount * 100)/13;
        }

        public void DisplayEfficiency () 
        {
            Console.WriteLine($"Worker efficiency based on amount of beer '{Beer_Name}': {Efficiency}% ");
        }
    }
}
