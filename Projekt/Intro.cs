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
            Console.WriteLine("Willkommen zu:");
            Console.WriteLine("--- Gefangen im Labyrinth ---");
            Console.WriteLine();
            Console.WriteLine("Du wachst auf in irgendeinem Raum, du hast keine Ahnung wie du hier gelandet bist und kannst dich selbst erst langsam wieder an deinen Namen erinnern.");
            Console.WriteLine("Wie soll dein Charakter heißen?");

            string name = Console.ReadLine() ?? "Unbekannt";
            Spieler spieler = new Spieler(name, 0, 0, 0, 0);
            Console.Clear();

            bool auswahl = false;

            while (!auswahl)
            {
                auswahl = true;
                Console.WriteLine($"{name}, nachfolgend kannst du aussuchen, welche Klasse dein Charakter haben soll. Entweder Krieger, Schütze oder Sammler.");
                Console.WriteLine("Wähle weise, auf deinem Weg kannst du die einzigartigen Stats, die jede Klasse mit sich bringt, nicht mehr ändern.");
                Console.WriteLine("Wähle deine Klasse:");
                Console.WriteLine("1 - Krieger (mehr Schaden)");
                Console.WriteLine("2 - Schütze (mehr Gesundheit)");
                Console.WriteLine("3 - Sammler (mehr Inventarplätze)");

                string eingabe = Console.ReadLine() ?? "";
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

                Console.WriteLine("Dein Ziel: Entkomme dem Labyrinth – oder stirb bei dem Versuch.");
                Console.WriteLine();
                Console.WriteLine("Drei Wege stehen dir offen...");
                Console.WriteLine("Wähle deinen Pfad mit Bedacht.");
                Console.WriteLine();
                Console.WriteLine("Drücke eine Taste, um fortzufahren...");
                Console.ReadKey();
                Console.Clear();
            }
            

            
            return spieler; 
        }
    }
} 
