using domowa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace ZadanieDomowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker Maciej = new Worker("Romper");
            Maciej.DisplayEfficiency();

            Nerd Mateusz = new Nerd(4.7f, "Somersby");
            Mateusz.DisplayNotesAmount();

            Basic Miron = new Basic(3.0f, "Tyskie");
            Miron.DisplayNewFriends();
        }
    }
}
