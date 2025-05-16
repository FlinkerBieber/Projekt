using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt
{
    internal static class Intro

    {
       

        public static Spieler IntroAnfang()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
╔═══════════════════════════════════╗
║     W I L L K O M M E N   Z U     ║
║    ── Gefangen im Labyrinth ──    ║
╚═══════════════════════════════════╝
");
            Console.ResetColor();
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("Ein kalter Steinboden. Dunkelheit. Stille.");
            Thread.Sleep(2000);
            Console.WriteLine("Deine Augen öffnen sich langsam – verschwommen, benommen.");
            Thread.Sleep(2500);
            Console.WriteLine("Du hörst nur dein Atmen... und irgendwo das Tropfen von Wasser.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wer... bist du?");
            Console.ResetColor();
            Thread.Sleep(1500);
            Console.WriteLine("Dein Verstand kämpft sich zurück, Bilder flackern auf.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.Write("Wie lautet dein Name, Abenteurer? ");

            string name = Console.ReadLine() ?? "Unbekannt";
            Spieler spieler = new Spieler(name, 0, 0, 0, 0);
            Console.Clear();

            bool auswahl = false;

            while (!auswahl)
            {
                auswahl = true;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"
╔════════════════════════════════════════════════════╗
║           W Ä H L E   D E I N E   K L A S S E       ║
╚════════════════════════════════════════════════════╝
");
                Console.ResetColor();
                Thread.Sleep(1000);

                Console.WriteLine($"{name}, es ist an der Zeit, deinen Weg zu wählen...");
                Thread.Sleep(2000);
                Console.WriteLine("Drei Wege. Drei Schicksale. Doch nur einer ist deiner.");
                Thread.Sleep(2500);
                Console.WriteLine();
                Console.WriteLine("Wähle weise – deine Entscheidung prägt deine Reise und ist unumkehrbar.");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - Krieger   » Brutale Kraft | Höherer Schaden");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2 - Schütze   » Zäher Überlebenskünstler | Mehr Gesundheit");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3 - Sammler   » Gerissener Entdecker | Mehr Inventarplätze");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.Write("Deine Wahl (1/2/3): ");
                string eingabe = Console.ReadLine() ?? "";
                Console.Clear();
                int wahl;

                if (int.TryParse(eingabe, out wahl))
                {
                    switch (wahl)
                    {
                        case 1:
                            spieler.Gesundheit = 100;
                            spieler.MinSchaden = 15;
                            spieler.MaxSchaden = 25;
                            spieler.Inventarplaetze = 8;
                            break;
                        case 2:
                            spieler.Gesundheit = 150;
                            spieler.MinSchaden = 8;
                            spieler.MaxSchaden = 12;
                            spieler.Inventarplaetze = 8;
                            break;
                        case 3:
                            spieler.Gesundheit = 100;
                            spieler.MinSchaden = 5;
                            spieler.MaxSchaden = 15;
                            spieler.Inventarplaetze = 15;
                            break;
                        case 050797:
                            spieler.Gesundheit = 100;
                            spieler.MinSchaden = 1100;
                            spieler.MaxSchaden = 1100;
                            spieler.Inventarplaetze = 100;
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl. Bitte 1, 2 oder 3 eingeben.");
                            auswahl = false;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                    auswahl = false;
 
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
╔═══════════════════════════════════════════════╗
║              D E I N   Z I E L                ║
╚═══════════════════════════════════════════════╝
");
                Console.ResetColor();
                Thread.Sleep(1000);

                Console.WriteLine("Dein Ziel ist klar:");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("» Entkomme dem Labyrinth – oder stirb bei dem Versuch. «");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Vor dir tun sich drei dunkle Wege auf...");
                Thread.Sleep(2000);
                Console.WriteLine("Jeder führt zu einem anderen Schicksal.");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Wähle deinen Pfad mit Bedacht.");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Drücke eine beliebige Taste, um dich dem Unbekannten zu stellen...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            

            
            return spieler; 
        }
    }
} 
