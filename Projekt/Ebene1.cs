using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal static class Ebene1
    {

        public static void StoryEbene1(Kampflogik kampflogik, Spieler spieler)
        {
            Gegner ratte = new Gegner("Schattenratte", 30, 5, 10,30 );
            Gegner krabbler = new Gegner("knochenkrabbler", 35, 6, 11, 35);
            Gegner spinne = new Gegner("Spinne", 35, 6, 15, 35);
            Gegner wächter = new Gegner("Wächter", 50, 7, 20, 50 );
            List<string> besuchteWege = new List<string>();
            bool weiter = false;
            string eingabe = Console.ReadLine()?.Trim() ?? "";

            

                Console.WriteLine("Du betrittst die finsteren Hallen der Schatten.");
                Console.WriteLine("Ein kalter Wind weht durch die zerfallenen Mauern.");
                Console.WriteLine("\nVor dir verzweigen sich drei Gänge:");

            while (!weiter)
            {
             
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Gehe nach links");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Gehe durch den schmalen Spalt direkt vor dir");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Gehe nach rechts");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Plötzlich raschelt es im Dunkeln!");
                    Console.WriteLine("Eine Schattenratte greift dich an!");
                    kampflogik.Kämpfe(spieler, ratte);
                    Console.WriteLine("Du hast den Kampf überlebt und kannst weitergehen.");
                   

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
                    Console.WriteLine("Der Gang endet an einer zugemauerten Wand. Sackgasse.");
                    besuchteWege.Add("3");
                }
                else
                {
                    Console.WriteLine("Ungültig oder bereits besucht.");
                }
            }

            // Abschnitt 2
            weiter = false;
            besuchteWege.Clear();

            while (!weiter)
            {
                Console.WriteLine("\nDrei neue Gänge eröffnen sich:");
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Geradeaus zu einem alten Händler");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Modriger Gang zur linken Seite");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Tunnel mit Spinnweben zur Rechten");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    bool einkaufen = true;

                    while (einkaufen)
                    {
                        Console.WriteLine($"\nGold: {spieler.Gold}");
                        Console.WriteLine("Was möchtest du kaufen?");
                        Console.WriteLine("1 - Dolch (+2 Schaden) – 15 Gold");
                        Console.WriteLine("2 - Lederweste (+5 HP) – 20 Gold");
                        Console.WriteLine("3 - Heiltrank (+20 HP) – 5 Gold");
                        Console.WriteLine("0 - Nichts kaufen / Verlassen");

                        string kauf = Console.ReadLine()?.Trim() ?? "";

                        if (kauf == "1")
                        {
                            if (spieler.Gold >= 15)
                            {
                                Console.WriteLine("Du kaufst einen Dolch.");
                                spieler.MinSchaden += 2;
                                spieler. MaxSchaden+= 2;
                                spieler.Gold -= 15;
                            }
                            else Console.WriteLine("Nicht genug Gold.");
                        }
                        else if (kauf == "2")
                        {
                            if (spieler.Gold >= 20)
                            {
                                Console.WriteLine("Du ziehst die Lederweste an.");
                                spieler.MaxGesundheit += 5;
                                spieler.Gesundheit += 5;
                                spieler.Gold -= 20;
                            }
                            else Console.WriteLine("Nicht genug Gold.");
                        }
                        else if (kauf == "3")
                        {
                            if (spieler.Gold >= 10)
                            {
                                Console.WriteLine("Du trinkst den Heiltrank.");
                                spieler.Gesundheit += 20;
                                if (spieler.Gesundheit > spieler.MaxGesundheit)
                                    spieler.Gesundheit = spieler.MaxGesundheit;
                                spieler.Gold -= 5;
                            }
                            else Console.WriteLine("Nicht genug Gold.");
                        }
                        else if (kauf == "0")
                        {
                            Console.WriteLine("Du verlässt den Händler.");
                            einkaufen = false;
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe.");
                        }
                    }

                    besuchteWege.Add("1");
                }
                else if (eingabe == "2" && !besuchteWege.Contains("2"))
                {
                    Console.WriteLine("Ein Knochenkrabbler springt aus dem Schatten!");
                    kampflogik.Kämpfe(spieler, krabbler);
                    Console.WriteLine("Du hast ihn besiegt. Weiter geht’s.");
                    weiter = true;
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.WriteLine("Nur eine tote Spinne. Sackgasse.");
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

            while (!weiter)
            {
                Console.WriteLine("\nLetzte Weggabelung vor dem Endboss:");
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Ein Gang, aus dem Kratzen zu hören ist");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Gang mit leuchtender Fackel");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Stillen Tunnel mit eingestürztem Boden");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.WriteLine("Eine riesige Schattenspinne fällt von der Decke!");
                    kampflogik.Kämpfe(spieler, spinne);
                    Console.WriteLine("Du hast sie besiegt. Zeit, dich dem Endboss zu stellen.");
                    weiter = true;
                }
                else if (eingabe == "2" && !besuchteWege.Contains("2"))
                {
                    Console.WriteLine("Du findest einen Heiltrank.");
                    
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.WriteLine("Der Boden bricht unter dir ein. Du rettest dich gerade noch. Sackgasse.");
                    besuchteWege.Add("3");
                }
                else
                {
                    Console.WriteLine("Ungültig oder bereits besucht.");
                }
            }
            besuchteWege.Clear();
            weiter = false;

            while (!weiter)
            {
                Console.WriteLine("Drücke eine beliebige Taste, um den Kampf zu starten...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Du erreichst eine große Steintür mit eingravierten Symbolen.");
                Console.WriteLine("Als du sie öffnest, spürst du sofort eine drückende Präsenz.");
                Console.WriteLine("In der Mitte der Halle steht eine dunkle Gestalt, umgeben von schwarzem Nebel.");
                Console.WriteLine("Es ist der 'Finsterwächter' – der Hüter des Ebenenübergangs!");
                Console.WriteLine("Er hebt sein verfluchtes Schwert und schreit: 'Niemand passiert diesen Punkt!'");

                Console.WriteLine("Der Kampf gegen den Miniboss beginnt!");
                Console.WriteLine("Drücke eine beliebige Taste, um den Kampf zu starten...");
                Console.ReadKey();

                kampflogik.Kämpfe(spieler, wächter);

                if (wächter.Gesundheit < 0)
                {
                    Console.WriteLine("Du hast den Finsterwächter besiegt!");
                    Console.WriteLine("Sein Körper zerfällt zu Staub und gibt den Weg zur nächsten Ebene frei.");
                    Console.WriteLine("Du findest 40 Gold und ein mächtiges Item: 'Splitter der Schattenrüstung' (+10 HP)");
                    spieler.MaxGesundheit += 10;
                    spieler.Gesundheit += 10;
                    spieler.Gold += 40;
                    weiter = true;
                }
                else if (spieler.Gesundheit <= 0)
                {
                    Console.WriteLine("Du bist gefallen. Das Abenteuer endet hier.");
                    break;
                }
            }
        }


        }

    } 
    
   

