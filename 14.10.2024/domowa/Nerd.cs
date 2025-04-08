using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDomowe;

namespace domowa
{
    public class Nerd : Student
    {
        public int Notes_Amount { get; }

        public Nerd(float average, string beer_name) : base ( average, beer_name)
        {
            Notes_Amount = 100 - ( (Beer_Amount * 100) / 13);
        }

        public void DisplayNotesAmount() 
        {
            Console.WriteLine($"Nerd has currently drank {Beer_Amount} {(Beer_Amount==1 ? "beer" : "beers")} his notes amount is: {Notes_Amount}%");
        }
    }
}
