using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal static class Ebene1
    {

        public static void StoryEbene1(Kampflogik kampflogik, Spieler spieler1)
        {
            Gegner ratte = new Gegner("Schattenratte", 30, 5, 10);
            Gegner krabbler = new Gegner("knochenkrabbler", 35, 6, 11);
            Gegner spinne = new Gegner("Spinne", 35, 6, 15);
            Gegner wächter = new Gegner("Wächter", 50, 7, 20);
            Spieler spieler = new Spieler("name", 0, 0, 0);
            List<string> besuchteWege = new List<string>();
            bool weiter = false;


            Console.WriteLine("Du betrittst die finsteren Hallen der Schatten.");
            Console.WriteLine("Ein kalter Wind weht durch die zerfallenen Mauern.");
            Console.WriteLine("Vor dir verzweigen sich drei Gänge.");
            Console.WriteLine("1 - Gehe nach links");
            Console.WriteLine("2 - Gehe durch den schmalen Spalt direkt vor dir");
            Console.WriteLine("3 - Gehe nach rechts");

            Console.Write("Wähle deinen Weg (1-3): ");
            string eingabe = Console.ReadLine()?.Trim() ?? "";

            Console.WriteLine("Du betrittst die finsteren Hallen der Schatten.");
            Console.WriteLine("Ein kalter Wind weht durch die zerfallenen Mauern.");

            while (!weiter)
            {
                Console.WriteLine("\nVor dir verzweigen sich drei Gänge.");
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
                    Console.WriteLine("Du zwängst dich durch den Spalt und findest eine versteckte Nische.");
                    Console.WriteLine("In einer Truhe findest du 20 Goldmünzen!");
                    besuchteWege.Add("2");
                }
                else if (eingabe == "3" && !besuchteWege.Contains("3"))
                {
                    Console.WriteLine("Du läufst einen dunklen Gang entlang...");
                    Console.WriteLine("...nur um festzustellen, dass du vor einer zugemauerten Wand stehst.");
                    Console.WriteLine("Zeitverschwendung. Du kehrst um.");
                    besuchteWege.Add("3");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe oder dieser Weg wurde bereits betreten.");
                }
            }

            //man kommt nur weiter wenn man gegen gekämpft hat bei weg 1

            //abzweigung 2
            Console.WriteLine("nach dem letzten kampf atmest du schwer.");
            Console.WriteLine("1 - gehe geradeaus");
            Console.WriteLine("2 - folge dem modrigen gang zur linken seite");
            Console.WriteLine("3 - biege in den mit spinnweben bedeckten tunnel rechts ein");

            //auswahl 1 weg2
            Console.WriteLine("du betrittst einen raum mit einem alten, grinsenden händler.");
            Console.WriteLine("1 - dolch (+2 schaden) - 20 gold");
            Console.WriteLine("2 - lederweste (+5 hp) - 15 gold");
            Console.WriteLine("3 - heiltrank (+20 hp) - 10 gold");
            Console.WriteLine("0 - nichts kaufen");

            //auswahl 2 weg2
            Console.WriteLine("ein fauliger geruch liegt in der luft...");
            Console.WriteLine("plötzlich springt ein knochenkrabbler aus einem haufen alter schädel!");
            Console.WriteLine("der kampf beginnt!");
            kampflogik.Kämpfe(spieler, krabbler);

            //auswahl 3 weg2
            Console.WriteLine("du verirrst dich in einen von spinnweben bedeckten tunnel...");
            Console.WriteLine("...und findest nichts außer einer toten spinne.");
            Console.WriteLine("sackgasse. du gehst zurück.");

            //man kommt nur weiter wenn man gegner bekämpft hat bei weg 2

            //abzweigung 3
            Console.WriteLine("du schreitest tiefer in die düsteren hallen.");
            Console.WriteLine("drei gänge führen in unterschiedliche richtungen:");
            Console.WriteLine("1 - ein gang, aus dem ein kratzen zu hören ist");
            Console.WriteLine("2 - ein schmaler seitengang mit einer leuchtenden fackel an der wand");
            Console.WriteLine("3 - ein langer, stiller tunnel mit eingestürztem boden");
            //auswahl 1 weg 3
            Console.WriteLine("du gehst dem kratzen nach...");
            Console.WriteLine("eine riesige schattenspinne krabbelt von der decke herab!");
            Console.WriteLine("der kampf beginnt!");
            kampflogik.Kämpfe(spieler, spinne);


            //auswahl 2 weg 3
            Console.WriteLine("der gang endet in einem kleinen raum.");
            Console.WriteLine("in einer ecke findest du eine alte truhe.");
            Console.WriteLine("du öffnest sie vorsichtig und findest:");
            Console.WriteLine("- 15 gold");
            Console.WriteLine("- 1x heiltrank");
            // loot zum inventar hinzufügen
            //aushwahl 3 weg 3
            Console.WriteLine("du folgst dem tunnel...");
            Console.WriteLine("doch der boden bricht plötzlich unter dir ein!");
            Console.WriteLine("du kannst dich gerade noch festhalten und zurückklettern.");
            Console.WriteLine("sackgasse. du kehrst um.");

            // man kommt erst weiter wieder wenn man gekämpft hat 

            Console.WriteLine("Du erreichst eine große Steintür mit eingravierten Symbolen.");
            Console.WriteLine("Als du sie öffnest, spürst du sofort eine drückende Präsenz.");
            Console.WriteLine("In der Mitte der Halle steht eine dunkle Gestalt, umgeben von schwarzem Nebel.");
            Console.WriteLine("Es ist der 'Finsterwächter' – der Hüter des Ebenenübergangs!");
            Console.WriteLine("Er hebt sein verfluchtes Schwert und schreit: 'Niemand passiert diesen Punkt!'");

            Console.WriteLine("Der Kampf gegen den Miniboss beginnt!");
            kampflogik.Kämpfe(spieler, wächter);

            Console.WriteLine("Du hast den Finsterwächter besiegt!");
            Console.WriteLine("Sein Körper zerfällt zu Staub und gibt den Weg zur nächsten Ebene frei.");
            Console.WriteLine("Du findest 40 Gold und ein mächtiges Item: 'Splitter der Schattenrüstung' (+10 HP)");

        }

    } 
    
   
}
