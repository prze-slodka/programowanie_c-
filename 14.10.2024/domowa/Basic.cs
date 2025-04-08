using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieDomowe;

namespace ZadanieDomowe
{
    internal class Basic : Student
    {
        public int NewFriends { get; }

        public Basic(float average, string beer_name) : base(average, beer_name)
        {
            Random rnd = new Random();
            NewFriends = Beer_Amount * rnd.Next(1, 13);
        }

        public void DisplayNewFriends() 
        {
            Console.WriteLine($"Basic student drank {Beer_Amount} {(Beer_Amount == 1 ? "beer" : "beers")} and he made: {NewFriends} new {(NewFriends == 1 ? "friend" : "friends")}");
        }
    }
}
