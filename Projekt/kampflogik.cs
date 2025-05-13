using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projekt
{
    internal class Kampflogik

    {

        public void Kämpfe(Spieler spieler, Gegner gegner)
        {
            while (spieler.Gesundheit > 0 && gegner.Gesundheit > 0)
            {
                Console.Clear();
                Console.WriteLine($"🧍 {spieler.Name} vs. {gegner.Name} 🐀\n");
                ZeigeLebensbalken(spieler.Name, spieler.Gesundheit, 150);
                ZeigeLebensbalken(gegner.Name, gegner.Gesundheit, 100);
                Console.WriteLine();

                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1 - Angreifen");
                Console.WriteLine("2 - Heilen (+20 HP, 1x pro Kampf)");
                Console.Write("Aktion wählen: ");
                string aktion = Console.ReadLine()??"";

                if (aktion == "1")
                {
                    int spielerSchaden = new Random().Next(spieler.MinSchaden, spieler.MaxSchaden + 1);
                    gegner.Gesundheit -= spielerSchaden;
                    Console.WriteLine($"{spieler.Name} greift an und verursacht {spielerSchaden} Schaden!");
                }
                else if (aktion == "2")
                {
                    if (!spieler.HeilungBenutzt)
                    {
                        spieler.Gesundheit += 20;
                        spieler.HeilungBenutzt = true;
                        Console.WriteLine("Du hast dich geheilt! (+20 HP)");
                    }
                    else
                    {
                        Console.WriteLine("Du hast deine Heilung bereits verwendet!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }

                // Gegner greift zurück
                if (gegner.Gesundheit > 0)
                {
                    int gegnerSchaden = new Random().Next(gegner.MinSchaden, gegner.MaxSchaden + 1);
                    spieler.Gesundheit -= gegnerSchaden;
                    Console.WriteLine($"{gegner.Name} greift an und verursacht {gegnerSchaden} Schaden!");
                }

                Console.WriteLine("\nDrücke eine Taste für die nächste Runde...");
                Console.ReadKey();
            }

            Console.Clear();
            if (spieler.Gesundheit > 0)
                Console.WriteLine("🏆 Du hast gewonnen!");
            else
                Console.WriteLine("💀 Du bist gestorben...");
        }

        private void ZeigeLebensbalken(string name, int hp, int maxHp)
        {
            int breite = 20;
            int anzahl = (int)((double)hp / maxHp * breite);
            Console.Write($"{name}: [");
            Console.Write(new string('#', anzahl));
            Console.Write(new string('-', breite - anzahl));
            Console.WriteLine($"] {hp} HP");
        }
    }
}
