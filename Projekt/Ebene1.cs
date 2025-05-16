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


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║ Du betrittst die finsteren Hallen der Schatten ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("Ein kalter Wind weht durch die zerfallenen Mauern und streift deinen Nacken.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Vor dir verzweigen sich drei düstere Gänge...");
            Console.ResetColor();

            // Beispiel für Gangauswahl (nur Anfang, Rest wie gehabt)
            while (!weiter)
            {
                if (!besuchteWege.Contains("1")) Console.WriteLine("1 - Gehe nach links");
                if (!besuchteWege.Contains("2")) Console.WriteLine("2 - Gehe durch den schmalen Spalt direkt vor dir");
                if (!besuchteWege.Contains("3")) Console.WriteLine("3 - Gehe nach rechts");

                Console.Write("Wähle deinen Weg (1-3): ");
                eingabe = Console.ReadLine()?.Trim() ?? "";

                if (eingabe == "1" && !besuchteWege.Contains("1"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Plötzlich raschelt es im Dunkeln!");
                    Console.WriteLine("Eine Schattenratte greift dich an!");
                    Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Du betrittst eine staubige Kammer, in der ein alter Händler in Lumpen sitzt.");
                        Console.WriteLine("»Willkommen, Fremder... Gold gegen Überleben, das ist der Deal«, murmelt er.");
                        Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Eine riesige Schattenspinne fällt zischend von der Decke!");
                    Console.ResetColor();
                    Console.WriteLine("Ihr schwarzer Leib glänzt im matten Licht, und ihre acht Augen starren dich gierig an...");
                    kampflogik.Kämpfe(spieler, spinne);
                    Console.WriteLine("Du hast sie besiegt. Zeit, dich dem Boss der 1.sten Ebene zu stellen.");
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
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Du erreichst eine gigantische Steintür mit mystischen Gravuren.");
                Console.WriteLine("Ein kalter Nebel tritt aus den Ritzen, als du sie öffnest.");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Inmitten der Halle steht eine dunkle Gestalt – umhüllt von schwarzem Rauch.");
                Console.WriteLine("Der Finsterwächter erhebt sein verfluchtes Schwert:");
                Console.WriteLine("\"Niemand passiert diesen Punkt lebend!\"");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(" Der epische Kampf beginnt! ");
                Console.ReadKey();

                // --- Kampfergebnis ---
                kampflogik.Kämpfe(spieler, wächter);

                if (wächter.Gesundheit < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Mit einem letzten Hieb stürzt der Finsterwächter auf die Knie...");
                    Console.WriteLine("Sein Körper zerfällt zu schwarzem Staub, der sich im Wind verliert.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine(" Du findest 40 Gold!");
                    Console.WriteLine(" Außerdem entdeckst du ein seltenes Artefakt: »Splitter der Schattenrüstung« (+10 HP)");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Ebene 1 Abgeschloßen. Wenn sie mit Ebene 2 fortfahren möchten drücken sie eine beliebige Taste :");
                    Console.ReadKey();
                    Console.Clear();
                    spieler.MaxGesundheit += 10;
                    spieler.Gesundheit += 10;
                    spieler.Gold += 40;
                    weiter = true;
                }
                else if (spieler.Gesundheit <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dein letzter Atemzug entweicht...");
                    Console.WriteLine("Der Finsterwächter lacht triumphierend, während dein Körper regungslos zu Boden fällt.");
                    Console.WriteLine("»Ein weiterer Narr, der das Labyrinth nicht überlebte…«");
                    Console.ResetColor();
                    Console.WriteLine(" GAME OVER ");
                    break;
                }
            }
        }


    }

} 
    
   

