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
            Console.WriteLine("Du betrittst die zweite Ebene: Eine uralte Gruft, in der der Tod selbst zu wohnen scheint.");
            Console.WriteLine("Drei neue Wege tun sich vor dir auf:");

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
                    Console.WriteLine("Eine Statue greift dich an!");
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
                    Console.WriteLine("Eine verlorene Seele greift dich an!");
                    kampflogik.Kämpfe(spieler, verloreneSeele);
                    weiter = true;
                }
                else if (eingabe == "2" && !besuchteWege.Contains("2"))
                {
                    Console.WriteLine("Du findest 20 Gold in einer Truhe.");
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
                if (!besuchteWege.Contains("A")) Console.WriteLine("A - Raum voller Knochen");
                if (!besuchteWege.Contains("B")) Console.WriteLine("B - Raum mit Pilzen");
                if (!besuchteWege.Contains("C")) Console.WriteLine("C - Versteckte Nische");

                Console.Write("Wähle deinen Weg (A-C): ");
                eingabe = Console.ReadLine()?.Trim().ToUpper() ?? "";

                if (eingabe == "A" && !besuchteWege.Contains("A"))
                {
                    Console.WriteLine("Eine Skelettbestie greift dich an!");
                    kampflogik.Kämpfe(spieler, skelettBestie);
                    weiter = true;
                }
                else if (eingabe == "B" && !besuchteWege.Contains("B"))
                {
                    Console.WriteLine("Du findest einen sicheren Durchgang – kein Kampf.");
                    weiter = true;
                }
                else if (eingabe == "C" && !besuchteWege.Contains("C"))
                {
                    Console.WriteLine("Eine leere Truhe – der Weg ist versperrt.");
                    besuchteWege.Add("C");
                }
                else
                {
                    Console.WriteLine("Ungültig oder bereits besucht.");
                }
            }

            // Händler
            Console.WriteLine("\nDu findest einen Händler:");
            Console.WriteLine("1 - Stahlschwert (+3 Schaden)");
            Console.WriteLine("2 - Eisenrüstung (+10 HP)");
            Console.WriteLine("3 - Heiltrank (+30 HP)");
            Console.WriteLine("0 - Nichts kaufen");

            eingabe = Console.ReadLine()?.Trim() ?? "";

            switch (eingabe)
            {
                case "1":
                    if (spieler.Gold >= 30) { spieler.Schaden += 3; spieler.Gold -= 30; Console.WriteLine("Gekauft."); }
                    else Console.WriteLine("Nicht genug Gold.");
                    break;
                case "2":
                    if (spieler.Gold >= 40) { spieler.Gesundheit += 10; spieler.Gold -= 40; Console.WriteLine("Gekauft."); }
                    else Console.WriteLine("Nicht genug Gold.");
                    break;
                case "3":
                    if (spieler.Gold >= 20) { spieler.Gesundheit += 30; spieler.Gold -= 20; Console.WriteLine("Gekauft."); }
                    else Console.WriteLine("Nicht genug Gold.");
                    break;
                case "0":
                    Console.WriteLine("Du ziehst weiter.");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }

            // Miniboss
            Console.WriteLine("\nEin riesiger Trolldämon stellt sich dir in den Weg!");
            kampflogik.Kämpfe(spieler, trollDaemon);

            if (spieler.Gesundheit > 0)
            {
                Console.WriteLine("Du hast den Trolldämon besiegt!");
                Console.WriteLine("Die Wand hinter ihm bricht auf und führt zur dritten Ebene.");
            }
            else
            {
                Console.WriteLine("Du bist gefallen. Dein Abenteuer endet hier.");
            }
        }
    }
}
        

        