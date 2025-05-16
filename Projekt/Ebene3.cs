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
            Gegner KönigDerSchatten = new Gegner("HerrderSchatten", 200, 25, 45, 250);

            List<string> besuchteWege = new List<string>();
            bool weiter = false;
            string eingabe = "";



            // Abschnitt 1
            Console.Clear();

            Console.WriteLine("Du betrittst einen finsteren Raum, wo Schatten in den Ecken lauern...");


            // Abschnitt 1
            weiter = false;
            besuchteWege.Clear();
            while (!weiter)
            {
                Console.WriteLine("\n┌───────────────────────────────┐");
                Console.WriteLine("│ Drei Wege öffnen sich vor dir: │");
                Console.WriteLine("└───────────────────────────────┘");
                if (!besuchteWege.Contains("1")) Console.WriteLine(" [1]  Düsterer Gang mit schwachem Licht");
                if (!besuchteWege.Contains("2")) Console.WriteLine(" [2]  Raum mit plätscherndem Wasser");
                if (!besuchteWege.Contains("3")) Console.WriteLine(" [3]  Steiniger Tunnel mit Echo");

                Console.Write("\nWähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n  Ein Alter Wächter stürzt aus den Schatten auf dich zu!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, wächter);
                    weiter = true;
                }
                else if (eingabe == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n Der Raum stürzt ein! Sackgasse!");
                    Console.ResetColor();
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n Ein unheimlicher Geist greift dich an!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, geist);
                    weiter = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n⚠ Ungültige Eingabe oder Weg schon betreten.");
                    Console.ResetColor();
                }
            }

            // Abschnitt 2
            weiter = false;
            besuchteWege.Clear();
            while (!weiter)
            {
                Console.WriteLine("\n───────────────────────────────");
                Console.WriteLine("Weitere Kreuzung – was wählst du?");
                Console.WriteLine("───────────────────────────────");
                if (!besuchteWege.Contains("1")) Console.WriteLine(" [1]  Gang mit Spinnweben");
                if (!besuchteWege.Contains("2")) Console.WriteLine(" [2]  Dunkler Tunnel");
                if (!besuchteWege.Contains("3")) Console.WriteLine(" [3]  Raum mit geheimem Symbol");

                Console.Write("\nDeine Wahl (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Ein Tiger springt dich mit lautem Brüllen an!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, tiger);
                    weiter = true;
                }
                else if (eingabe == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n Eine unsichtbare Mauer blockiert deinen Weg. Sackgasse.");
                    Console.ResetColor();
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n Du löst ein uraltes Rätsel und findest ein mächtiges Artefakt.");
                    Console.ResetColor();
                    weiter = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n Ungültige Eingabe oder Weg schon betreten.");
                    Console.ResetColor();
                }
            }

            // Abschnitt 3
            weiter = false;
            besuchteWege.Clear();
            while (!weiter)
            {
                Console.WriteLine("\n───────────────────────────────");
                Console.WriteLine("Drei neue Wege erscheinen:");
                Console.WriteLine("───────────────────────────────");
                if (!besuchteWege.Contains("1")) Console.WriteLine(" [1] 👣 Gang mit leisen Schritten");
                if (!besuchteWege.Contains("2")) Console.WriteLine(" [2] 🔻 Treppe nach oben");
                if (!besuchteWege.Contains("3")) Console.WriteLine(" [3] 🏚️ Verwüsteter Raum");

                Console.Write("\nWähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Ein kleiner Schatten springt aus dem Dunkel!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, kleinerSchatten);
                    weiter = true;
                }
                else if (eingabe == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n Du fällst eine Treppe hinab. Sackgasse!");
                    Console.ResetColor();
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Ein mächtiger SteinGolem erhebt sich und greift an!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, steinGolem);
                    weiter = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n Ungültige Eingabe oder Weg schon betreten.");
                    Console.ResetColor();
                }
            }

            // Händler

            Console.WriteLine("Du erreichst eine kleine Raststätte, wo ein geheimnisvoller Händler wartet.");
            Console.WriteLine("Du darfst dir eine Sache kostenlos aussuchen:\n");
            Console.WriteLine(" [1]  Heiltrank (+8 Schaden)");
            Console.WriteLine(" [2]  Rüstung (+15 Gesundheit)");
            Console.WriteLine(" [3]  Magisches Elixier (+30 Gesundheit)");
            Console.Write("\nDeine Wahl: ");
            eingabe = Console.ReadLine()?.Trim() ?? "";

            switch (eingabe)
            {
                case "1":
                    spieler.Schaden += 8;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n🍷 Du trinkst einen Heiltrank. (+8 Schaden)");
                    Console.ResetColor();
                    break;
                case "2":
                    spieler.Gesundheit += 15;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n🛡️ Du rüstest eine starke Rüstung aus. (+15 Gesundheit)");
                    Console.ResetColor();
                    break;
                case "3":
                    spieler.Gesundheit += 30;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Du trinkst ein magisches Elixier. (+30 Gesundheit)");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nDu entscheidest dich, nichts zu nehmen.");
                    Console.ResetColor();
                    break;
            }

            // Schere-Stein-Papier Spiel

            Console.WriteLine("Ein geheimnisvoller Schatten stellt dich vor das letzte Spiel:");
            Console.WriteLine("Schere, Stein oder Papier?");
            Console.WriteLine("Gewinnst du, erhältst du +20 Leben und +20 Schaden für den Endkampf.");

            if (ScherSteinPapier.SpieleSchereSteinPapier())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Du gewinnst das Spiel! Deine Kräfte wachsen!");
                Console.ResetColor();

                spieler.MaxGesundheit += 20;
                spieler.Gesundheit += 20;
                spieler.MinSchaden += 10;
                spieler.MaxSchaden += 10;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Du verlierst das Spiel. Keine Veränderung.");
                Console.ResetColor();
            }

            Console.WriteLine("\nBereit für den finalen Kampf? Drücke eine beliebige Taste...");
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Ein mächtiges Tor öffnet sich. Der König der Schatten betritt die Arena!");
            Console.ResetColor();

            kampflogik.Kämpfe(spieler, KönigDerSchatten);

            Console.Clear();

            Console.WriteLine("Gerade als du den Herr der Schatten endgültig besiegst und erschöpft auf dem Schlachtfeld stehst,");
            Console.WriteLine("beginnt sein Körper in dunklem Rauch zu zerfallen. Doch sein leises Lachen bleibt...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Herr der Schatten:");
            Console.ResetColor();
            Console.WriteLine("\"Du glaubst, du hättest gewonnen? Du hast mir nur genau das gegeben, was ich brauchte...");
            Console.WriteLine("Deinen Zorn, deine Kraft – deine Seele!\"");
            Console.WriteLine();
            Console.WriteLine("Die Umgebung bebt, die Realität zerbricht wie Glas.");
            Console.WriteLine("Plötzlich findest du dich in einer dunklen Leere –");
            Console.WriteLine("und erkennst dein Spiegelbild in der Rüstung des Schattenfürsten.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Erzähler:");
            Console.ResetColor();
            Console.WriteLine("\"In deinem Kampf gegen das Böse bist du selbst zur dunklen Macht geworden...");
            Console.WriteLine("Du bist nun der neue Herr der Schatten.\"");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ende?");
            Console.WriteLine("Oder ist es erst der Anfang…");
            Console.ResetColor();
        }
    }
}   
