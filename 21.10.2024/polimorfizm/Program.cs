using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            // making Defenders
            Pikeman Maciek = new Pikeman();
            Pikeman Alojzy = new Pikeman();
            Crossbowman Andrzej = new Crossbowman();
            Crossbowman Czeslaw = new Crossbowman();

            //making Civils
            Civil Miloslaw = new Civil();
            Civil Makumba = new Civil();

            //making list of citizens
            Citizen[] citizens = { Maciek, Alojzy, Andrzej, Czeslaw, Miloslaw, Makumba };

            //making list of crossbowmen
            Crossbowman[] crossbowmen = { Andrzej, Czeslaw };

            //making list of defenders
            Defender[] defenders = { Maciek, Alojzy, Andrzej, Czeslaw };

            //running method ReadyToFight for each crossbowman
            foreach (Crossbowman crossbowman in crossbowmen) 
            {
                Console.WriteLine(crossbowman.ReadyToFight());
            }

            Console.WriteLine("\n");

            //running method ReadyToFight for each defender
            foreach (Defender defender in defenders)
            {
                Console.WriteLine(defender.ReadyToFight());
            }

            Console.WriteLine("\n");

            //running method ToString + Eat for each citizen
            foreach (Citizen citizen in citizens)
            {
                Console.WriteLine($"{citizen.ToString()} : {citizen.Eat()}");
            }
        }
    }
}
