using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
                ZeigeLebensbalken(spieler.Name, spieler.Gesundheit, spieler.MaxGesundheit);
                ZeigeLebensbalken(gegner.Name, gegner.Gesundheit, gegner.MaxGesundheit);
                Console.WriteLine();

                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1 - Angreifen");
                Console.WriteLine("2 - Heilen (+20 HP, 1x pro Kampf)");
                Console.Write("Aktion wählen: ");
                string aktion = Console.ReadLine() ?? "";

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
            else if (spieler.Gesundheit <= 0)
            {
                Console.WriteLine("💀 Du bist gestorben... Das Abenteuer endet hier.");
                Console.WriteLine("Möchtest du von vorne beginnen? (j/n): ");
                string antwort = Console.ReadLine()?.Trim().ToLower()??"";
                if (antwort == "j")
                {
                    // Spiel zurücksetzen (z. B. Gesundheit, Gold, Inventar etc.)
                    spieler = new Spieler("", 100, 7, 15,100);
                    Console.WriteLine("Ein neues Abenteuer beginnt...");
                }
                else
                {
                    Console.WriteLine("Spiel wird beendet. Danke fürs Spielen!");
                    Environment.Exit(0);
                }
            }

            static void ZeigeLebensbalken(string name, int hp, int maxHp)
            {

                int breite = 20;
                int anzahl = (int)((double)hp / maxHp * breite);
                anzahl = Math.Clamp(anzahl, 0, breite); // anzahl darf nicht < 0 oder > breite sein

                double prozent = (double)hp / maxHp;
                if (prozent >= 0.7)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (prozent >= 0.3)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write($"{name}: [");
                Console.Write(new string('#', anzahl));
                Console.ResetColor();
                Console.Write(new string('-', breite - anzahl));
                Console.WriteLine($"] {hp} HP");
            }
        }
    }
}
