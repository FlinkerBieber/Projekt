// abstracte klasse kann ich schon in der auswahl der rollen anhandeln

// public abstract class Rolle
// 



//Startmenü
//Klassenauswahl 
// Namenauswahl 
//kampfsystem
//shopsystem

// abzweigung 1
using Projekt;
using System;
using System.Runtime.ConstrainedExecution;
using System.IO;
using System.Text.Json;


bool spielLaeuft = true;

while (spielLaeuft)
{
    bool istGeburtstag = DateTime.Now.Month == 7 && DateTime.Now.Day == 5;
    Spieler spieler = null;

    Console.Clear();
    Console.WriteLine("╔══════════════════════════════╗");
    Console.WriteLine("║        MAIN MENU             ║");
    Console.WriteLine("╠══════════════════════════════╣");
    Console.WriteLine("║  1 - Neues Spiel starten     ║");
    Console.WriteLine("║  2 - Spielstand laden        ║");
    Console.WriteLine("╚══════════════════════════════╝");
    Console.Write("\nWähle eine Option: ");
    string auswahl = Console.ReadLine() ?? "";
    Console.Clear();

    if (auswahl == "1")
    {
        spieler = Intro.IntroAnfang();
    }
    else if (auswahl == "2")
    {
        spieler = Speichern_Laden.Laden();
    }

    if (spieler != null)
    {
        Console.WriteLine($"Willkommen, {spieler.Name}!");
        Console.WriteLine($"Gesundheit: {spieler.Gesundheit}");
        Console.WriteLine($"Schaden: {spieler.MaxSchaden}");
        Console.WriteLine($"Inventarplätze: {spieler.Inventarplaetze}");
        Console.WriteLine("Taste drücken um fortzufahren");
        Console.ReadKey();
        Console.Clear();

        Kampflogik kampflogik = new Kampflogik();

        Ebene1.StoryEbene1(kampflogik, spieler);
        if (spieler.Gesundheit > 0)
            Ebene2.StoryEbene2(kampflogik, spieler);
        if (spieler.Gesundheit > 0)
            Ebene3.StoryEbene3(kampflogik, spieler);

        if (spieler.Gesundheit <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDu bist gestorben! Das Spiel startet neu...");
            Console.ResetColor();
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nHerzlichen Glückwunsch! Du hast das Spiel überlebt!");
            spielLaeuft = false; // beende Spiel bei Erfolg
        }
    }
    else
    {
        Console.WriteLine("Charaktererstellung fehlgeschlagen.");
    }
}





