using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Ebene3
    {
        public static void StoryEbene3(Kampflogik kampflogik, Spieler spieler)
        {
            Gegner wächter = new Gegner("AlterWächter", 30, 5, 10, 30);
            Gegner geist = new Gegner("Geist", 35, 6, 11, 35);
            Gegner tiger = new Gegner("Tiger", 35, 6, 15, 35);
            Gegner kleinerSchatten = new Gegner("KleinerSchatten", 50, 7, 20, 50);
            Gegner steinGolem = new Gegner("SteinGolem", 50, 7, 20, 50);
            Gegner herrSchatten = new Gegner("HerrderSchatten", 200, 25, 45, 250);

            List<string> besuchteWege = new List<string>();
            bool weiter = false;
            string eingabe = "";

            Console.WriteLine("Du betrittst die dritte Ebene: Ein finsterer Raum voller Schatten.");

            // Abschnitt 1
            weiter = false;
            besuchteWege.Clear();
            while (!weiter)
            {
                Console.WriteLine("\nDrei Wege tun sich vor dir auf:");
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Dusterer Gang mit schwachem Licht");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Raum mit plätscherndem Wasser");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Steiniger Tunnel mit Echo");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Ein Alter Wächter greift dich an!");
                    kampflogik.Kämpfe(spieler, wächter);
                    weiter = true;
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Der Raum stürzt ein. Sackgasse.");
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.WriteLine("Ein Geist greift dich an!");
                    kampflogik.Kämpfe(spieler, geist);
                    weiter = true;
                }
                else Console.WriteLine("Ungültige Eingabe oder Weg schon betreten.");
            }

            // Abschnitt 2
            weiter = false;
            besuchteWege.Clear();
            while (!weiter)
            {
                Console.WriteLine("\nEine weitere Kreuzung erscheint:");
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Gang mit Spinnweben");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Dunkler Tunnel");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Raum mit geheimem Symbol");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Ein Tiger springt dich an!");
                    kampflogik.Kämpfe(spieler, tiger);
                    weiter = true;
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Eine Mauer versperrt den Weg. Sackgasse.");
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("Du löst ein Rätsel und findest ein Artefakt.");
                    weiter = true;
                }
                else Console.WriteLine("Ungültige Eingabe oder Weg schon betreten.");
            }

            // Abschnitt 3
            weiter = false;
            besuchteWege.Clear();
            while (!weiter)
            {
                Console.WriteLine("\nDrei Wege erscheinen erneut:");
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Gang mit leisen Schritten");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Treppe nach oben");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Verwüsteter Raum");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Ein Kleiner Schatten greift dich an!");
                    kampflogik.Kämpfe(spieler, kleinerSchatten);
                    weiter = true;
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Du fällst eine Treppe hinab. Sackgasse.");
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("Ein SteinGolem greift dich an!");
                    kampflogik.Kämpfe(spieler, steinGolem);
                    weiter = true;
                }
                else Console.WriteLine("Ungültige Eingabe oder Weg schon betreten.");
            }

            // Händler
            Console.WriteLine("\nDu erreichst eine Raststätte mit einem Händler.");
            Console.WriteLine("1 - Heiltrank kaufen");
            Console.WriteLine("2 - Rüstung kaufen");
            Console.WriteLine("3 - Nichts kaufen");
            Console.Write("Deine Wahl: ");
            eingabe = Console.ReadLine()?.Trim() ?? "";
           

            // Endboss
            Console.WriteLine("\nEin Tor öffnet sich. Der Herr der Schatten erscheint!");
            kampflogik.Kämpfe(spieler, herrSchatten);

            Console.WriteLine("\nDer Schatten ist gefallen, doch etwas Dunkles lebt in dir weiter...");
            Console.WriteLine("== ENDE ==");
        }
}   }
