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

string pfad = @"C:\Users\NitscheDennis\Documents\Speicher.json"; 
Spieler spieler = null;

Console.WriteLine("1 - Neues Spiel starten");
Console.WriteLine("2 - Spielstand laden");
Console.Write("Wähle eine Option: ");
string auswahl = Console.ReadLine()??"";

if (auswahl == "1")
{
    spieler = Intro.IntroAnfang();
}
else if (auswahl == "2")
{
    spieler = Speichern_Laden.Laden(pfad);
}

if (spieler != null)
{
    Console.WriteLine($"Willkommen, {spieler.Name}!");
    Console.WriteLine($"Gesundheit: {spieler.Gesundheit}");
    Console.WriteLine($"Schaden: {spieler.MaxSchaden}");
    Console.WriteLine($"Inventarplätze: {spieler.Inventarplaetze}");

    // Kampflogik-Instanz erzeugen
    Kampflogik kampflogik = new Kampflogik();

    // StoryEbene1 aufrufen
    Ebene1.StoryEbene1(kampflogik, spieler, pfad);
}
else
{
    Console.WriteLine("Charaktererstellung fehlgeschlagen.");
}

 




