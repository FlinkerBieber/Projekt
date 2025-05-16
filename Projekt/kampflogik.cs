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
            string[] angriffsSprüche = 
            {
             "Du stürzt dich mutig auf deinen Gegner!",
             "Ein gezielter Hieb trifft ins Schwarze!",
             "Du schreist und schlägst mit voller Wucht zu!",
             "Ein schneller Angriff überrascht deinen Gegner!",
             "Mit entschlossener Miene schlägst du zu!",
             "Dein Schwert pfeift durch die Luft!",
             "Du springst vor und triffst dein Ziel mit Präzision!",
             "Mit einem Kampfschrei stürzt du dich ins Gefecht!",
             "Du nutzt eine Lücke in der Verteidigung!",
             "Dein Schlag erzittert selbst die Schatten!",
             "Ein wuchtiger Hieb lässt deinen Gegner zurücktaumeln!",
             "Du wirbelst herum und schlägst mit voller Kraft!",
             "Deine Klinge trifft mit voller Wucht!",
             "Du landest einen kritischen Treffer!",
             "Deine Entschlossenheit gibt dir Kraft für einen starken Schlag!"
            };
            Random random = new Random();
            spieler.HeilungBenutzt = false;
            bool istGeburtstag = DateTime.Now.Month == 7 && DateTime.Now.Day == 5;
            if (istGeburtstag)
            {
                gegner.Name = "Plüsch-" + gegner.Name;
                gegner.Gesundheit = 1;
                gegner.MinSchaden = 0;
                gegner.MaxSchaden = 1;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" Heute ist vom Entwickler der  Geburtstag! Alle Gegner sind peinlich schwach!");
                Console.WriteLine($" {gegner.Name} erscheint mit nur 1 HP und minimalem Schaden!");
                Console.ResetColor();
            }


            while (spieler.Gesundheit > 0 && gegner.Gesundheit > 0)
            {
                Console.Clear();
                Console.WriteLine($" {spieler.Name} vs. {gegner.Name} \n");
                ZeigeLebensbalken(spieler.Name, spieler.Gesundheit, spieler.MaxGesundheit);
                ZeigeLebensbalken(gegner.Name, gegner.Gesundheit, gegner.MaxGesundheit);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║         Was möchtest du tun?         ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║ 1 ➤   Angreifen                     ║");
                Console.WriteLine("║ 2 ➤   Heilen (+20 HP, 1x pro Kampf) ║");
                Console.WriteLine("║ 3 ➤   Status Anzeigen               ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.ResetColor();
                Console.Write(" Aktion wählen (1,2 oder 3): ");
                string aktion = Console.ReadLine() ?? "";

                if (aktion == "1")
                {
                    int spielerSchaden = new Random().Next(spieler.MinSchaden, spieler.MaxSchaden + 1);
                    gegner.Gesundheit -= spielerSchaden;
                    Console.WriteLine(angriffsSprüche[random.Next(angriffsSprüche.Length)]);
                    Console.WriteLine($"→ Du verursachst {spielerSchaden} Schaden!");
                    
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
                else if (aktion == "3")
                    {
                        spieler.ZeigeStats();
                        Console.WriteLine("Drücke eine Taste um fortzufahren...");
                        Console.ReadKey();
                        continue; // Zurück zur Aktionsauswahl
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
                Console.WriteLine(" Du hast gewonnen!");
            else if (spieler.Gesundheit <= 0)
            {
                Console.WriteLine(" Du bist gestorben... Das Abenteuer endet hier.");
                Console.WriteLine("Möchtest du von vorne beginnen? (j/n): ");
                string antwort = Console.ReadLine()?.Trim().ToLower()??"";
                if (antwort == "j")
                {
                    
                    spieler = new Spieler("", 100, 7, 15,100);
                    Console.WriteLine("Ein neues Abenteuer beginnt...");
                }
                else
                {
                    Console.WriteLine("Spiel wird beendet. Danke fürs Spielen!");
                    Environment.Exit(0);
                }
            }
            else if (spieler.Gesundheit > 0 &&gegner.Gesundheit <= 0)
            {
                Console.WriteLine($"{gegner.Name} wurde besiegt!");
                spieler.GegnerGetoetet++;
                if (spieler.GegnerGetoetet % 3 == 0)
                {
                    spieler.LevelUp();
                }

                return;
            }


            static void ZeigeLebensbalken(string name, int hp, int maxHp)
            {
                if (maxHp <= 0) maxHp = 100 ; // Schutz vor Division durch 0

                int breite = 20;
                double prozent = (double)hp / maxHp;
                int anzahl = (int)(prozent * breite);
                anzahl = Math.Clamp(anzahl, 0, breite); // nicht kleiner 0, nicht größer 20

                // Farbwahl je nach Lebenszustand
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
                Console.WriteLine($"] {hp} / {maxHp} HP");
            }
           
        }



    }
}
