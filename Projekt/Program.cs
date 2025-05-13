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


Spieler spieler = Intro.IntroAnfang();

if (spieler != null)
{
    Console.WriteLine($"Willkommen, {spieler.Name}!");
    Console.WriteLine($"Gesundheit: {spieler.Gesundheit}");
    Console.WriteLine($"Inventarplätze: {spieler.Inventarplaetze}");

    // Kampflogik-Instanz erzeugen
    Kampflogik kampflogik = new Kampflogik();

    // StoryEbene1 aufrufen
    Ebene1.StoryEbene1(kampflogik, spieler);
}
else
{
    Console.WriteLine("Charaktererstellung fehlgeschlagen.");
}




