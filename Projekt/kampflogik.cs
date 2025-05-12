using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Kampflogik
    {
        public void Kämpfe(Spieler spieler, Gegner gegner)
        {
            Console.WriteLine($"Ein {gegner.Name} greift dich an!");

            while (spieler.Gesundheit > 0 && gegner.Gesundheit > 0)
            {
                gegner.Gesundheit -= spieler.Schaden;
                Console.WriteLine($"Du triffst den {gegner.Name} für {spieler.Schaden} Schaden!");

                if (gegner.Gesundheit <= 0)
                {
                    Console.WriteLine($"{gegner.Name} wurde besiegt!");
                    return;
                }

                spieler.Gesundheit -= gegner.Schaden;
                Console.WriteLine($"{gegner.Name} trifft dich für {gegner.Schaden} Schaden!");
            }

            if (spieler.Gesundheit <= 0)
                Console.WriteLine("Du wurdest besiegt...");
        }
    }
}
