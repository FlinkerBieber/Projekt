using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Speichern_Laden
    {
        public static void Speichern(Spieler spieler, string pfad = "Speicher.json")
        {
            var optionen = new JsonSerializerOptions { WriteIndented = true }; 
            string json = JsonSerializer.Serialize(spieler, optionen);
            File.WriteAllText(pfad, json); 
            Console.WriteLine("Spielstand gespeichert.");
        }

        // Spielstand laden
        public static Spieler Laden(string pfad = "Speicher.json")
        {
            if (!File.Exists(pfad))
            {
                Console.WriteLine("Kein Spielstand gefunden.");
                return null; 
            }

            string json = File.ReadAllText(pfad); 
            Spieler spieler = JsonSerializer.Deserialize<Spieler>(json, new JsonSerializerOptions { IncludeFields = true }) ; 
            Console.WriteLine("Spielstand geladen.");
            return spieler;
        }

    }
}
