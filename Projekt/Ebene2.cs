using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projekt
{
    internal class Ebene2
    {
        public static void StoryEbene2(Kampflogik kampflogik, Spieler spieler)
        {
            Gegner statueritter = new Gegner("StatueRitter", 30, 5, 10, 30);
            Gegner verloreneSeele = new Gegner("VerloreneSeele", 35, 6, 11, 35);
            Gegner skelettBestie = new Gegner("SkeletteBestie", 35, 6, 15, 35);
            Gegner trollDaemon = new Gegner("TrollDaemon", 50, 7, 20, 50);

            List<string> besuchteWege = new List<string>();
            string eingabe;
            bool weiter = false;

            // Abschnitt 1
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║ Du betrittst die zweite Ebene: Eine uralte Gruft ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("Der Tod selbst scheint hier zu wohnen. Die Luft ist faulig und schwer.");
            Console.WriteLine("Drei neue Wege tun sich vor dir auf:\n");

            // Abschnitt 1
            weiter = false;
            besuchteWege.Clear();

            while (!weiter)
            {
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Durchgang mit blauem Licht");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Seitengang mit Knochen");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Gang mit Statuen");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Du findest eine Krypta mit 10 Gold.");
                    spieler.Gold += 10;
                    besuchteWege.Add("1");
                }
                else if (eingabe == "2" && !besuchteWege.Contains("2"))
                {
                    Console.WriteLine("Pfeilfalle! Du weichst aus, aber der Weg ist blockiert.");
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eine Statue erwacht zum Leben und greift dich an!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, statueritter);
                    weiter = true;
                }
                else
                {
                    Console.WriteLine("Ungültig oder bereits besucht.");
                }
            }

            // Abschnitt 2
            weiter = false;
            besuchteWege.Clear();
            Console.WriteLine("\nDrei neue Gänge stehen dir offen:");

            while (!weiter)
            {
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Dunkler Gang mit Säulen");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Tür mit Kerzenlicht");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Einsturzgefährdeter Korridor");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Eine verlorene Seele erscheint und greift dich an!");
                    Console.ResetColor();
                    kampflogik.Kämpfe(spieler, verloreneSeele);
                    weiter = true;
                }
                else if (eingabe == "2" && !besuchteWege.Contains("2"))
                {
                    Console.WriteLine("Du findest 20 Gold in einer verstaubten Truhe.");
                    spieler.Gold += 20;
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.WriteLine("Sackgasse wegen Einsturz. Du musst zurück.");
                    besuchteWege.Add("3");
                }
                else
                {
                    Console.WriteLine("Ungültig oder bereits besucht.");
                }
            }

            // Abschnitt 3
            weiter = false;
            besuchteWege.Clear();
            Console.WriteLine("\nDrei letzte Wege vor dem Miniboss:");

            while (!weiter)
            {
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Raum voller Knochen");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Raum mit Pilzen");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Versteckte Nische");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Eine Skelettbestie springt dich an!");
                    kampflogik.Kämpfe(spieler, skelettBestie);
                    weiter = true;
                }
                else if (eingabe == "2" && !besuchteWege.Contains("2"))
                {
                    Console.WriteLine("Du findest einen sicheren Durchgang – kein Kampf.");
                    weiter = true;
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.WriteLine("Eine leere Truhe... Der Weg ist versperrt.");
                    besuchteWege.Add("3");
                }
                else
                {
                    Console.WriteLine("Ungültig oder bereits besucht.");
                }
            }

            // Händler
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEin flackerndes Licht leitet dich zu einem Händler:");
            Console.WriteLine("»Gold gegen Leben oder Tod«, sagt er mit krächzender Stimme.");
            Console.ResetColor();
            Console.WriteLine("1 - Stahlschwert (+8 Schaden, 30 Gold)");
            Console.WriteLine("2 - Eisenrüstung (+15 HP, 40 Gold)");
            Console.WriteLine("3 - Heiltrank (+30 HP, 20 Gold)");
            Console.WriteLine("0 - Nichts kaufen");

            eingabe = Console.ReadLine()?.Trim() ?? "";

            switch (eingabe)
            {
                case "1":
                    if (spieler.Gold >= 30)
                    {
                        spieler.Schaden += 8;
                        spieler.Gold -= 30;
                        Console.WriteLine("Du greifst nach dem Stahlschwert. Es fühlt sich mächtig an.");
                    }
                    else Console.WriteLine("Nicht genug Gold.");
                    break;
                case "2":
                    if (spieler.Gold >= 40)
                    {
                        spieler.Gesundheit += 15;
                        spieler.Gold -= 40;
                        Console.WriteLine("Die Eisenrüstung liegt schwer, aber schützend auf deinen Schultern.");
                    }
                    else Console.WriteLine("Nicht genug Gold.");
                    break;
                case "3":
                    if (spieler.Gold >= 20)
                    {
                        spieler.Gesundheit += 30;
                        spieler.Gold -= 20;
                        Console.WriteLine("Du trinkst den Heiltrank. Wärme strömt durch deinen Körper.");
                    }
                    else Console.WriteLine("Nicht genug Gold.");
                    break;
                case "0":
                    Console.WriteLine("Du gehst schweigend weiter...");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }

            // Miniboss
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ein ohrenbetäubendes Brüllen hallt durch die Gruft!");
            Console.WriteLine("Ein riesiger Trolldämon mit brennenden Augen tritt aus dem Schatten!");
            Console.ResetColor();
            Console.WriteLine("🔥 Der Kampf gegen den Trolldämon beginnt! 🔥");

            kampflogik.Kämpfe(spieler, trollDaemon);

            if (spieler.Gesundheit > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mit letzter Kraft streckst du den Trolldämon nieder!");
                Console.ResetColor();
                Console.WriteLine("Die Wand hinter ihm bricht krachend auf und gibt den Weg zur dritten Ebene frei.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dein Körper sinkt kraftlos zu Boden... Das war dein Ende.");
                Console.ResetColor();
                Console.WriteLine(" GAME OVER ");
            }
        }
    }
}
        

        