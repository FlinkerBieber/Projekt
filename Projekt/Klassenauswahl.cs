using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Spieler
    {
        public string Name { get; set; }
        public int Gesundheit { get; set; }
        public int Schaden { get; set; }
        public int Inventarplaetze { get; set; }

        public void AuswahlKlassen()
        {
            Console.WriteLine("Wähle deine Klasse:");
            Console.WriteLine("1 - Krieger (mehr Schaden)");
            Console.WriteLine("2 - Schütze (mehr Gesundheit)");
            Console.WriteLine("3 - Sammler (mehr Inventarplätze)");

            string eingabe = Console.ReadLine()??"";
            int wahl;

            if (int.TryParse(eingabe, out wahl))
            {
                switch (wahl)
                {
                    case 1:
                        Gesundheit = 100;
                        Schaden = 20;
                        Inventarplaetze = 8;
                        break;
                    case 2:
                        Gesundheit = 150;
                        Schaden = 10;
                        Inventarplaetze = 8;
                        break;
                    case 3:
                        Gesundheit = 100;
                        Schaden = 10;
                        Inventarplaetze = 15;
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte 1, 2 oder 3 eingeben.");
                        AuswahlKlassen(); 
                        break;
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                AuswahlKlassen();
            }
        }
}   }