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
        public static void Speichern(Spieler spieler)
        {
            string ordner = @"C:\Users\NitscheDennis\OneDrive - LG - Academy\Desktop\Speicherstände";
            Directory.CreateDirectory(ordner);

            string dateipfad = Path.Combine(ordner, "spielstand.txt");

            string inhalt = $"Name:{spieler.Name}\n" +
                            $"Gesundheit:{spieler.Gesundheit}\n" +
                            $"MaxGesundheit:{spieler.MaxGesundheit}\n" +
                            $"MinSchaden:{spieler.MinSchaden}\n" +
                            $"MaxSchaden:{spieler.MaxSchaden}\n" +
                            $"Level:{spieler.Level}\n" +
                            $"Kills:{spieler.GegnerGetoetet}\n" +
                            $"Gold:{spieler.Gold}";

            File.WriteAllText(dateipfad, inhalt);
            Console.WriteLine(" Spielstand gespeichert!");
        }

        public static Spieler Laden()
        {
            string dateipfad = @"C:\Users\NitscheDennis\OneDrive - LG - Academy\Desktop\Speicherstände\spielstand.txt";

            if (!File.Exists(dateipfad))
            {
                Console.WriteLine(" Kein Spielstand gefunden.");
                return null;
            }

            string[] zeilen = File.ReadAllLines(dateipfad);
            Dictionary<string, string> daten = new();

            foreach (var zeile in zeilen)
            {
                var teile = zeile.Split(':');
                if (teile.Length == 2)
                    daten[teile[0]] = teile[1];
            }
            string json = File.ReadAllText(dateipfad);
            return JsonSerializer.Deserialize<Spieler>(json)!;
            Spieler geladenerSpieler = new Spieler(
                daten["Name"],
                int.Parse(daten["Gesundheit"]),
                int.Parse(daten["MinSchaden"]),
                int.Parse(daten["MaxSchaden"]),
                int.Parse(daten["MaxGesundheit"])
            );

            geladenerSpieler.Level = int.Parse(daten["Level"]);
            geladenerSpieler.GegnerGetoetet = int.Parse(daten["Kills"]);
            geladenerSpieler.Gold = int.Parse(daten["Gold"]);

            Console.WriteLine("Spielstand geladen.");
            return geladenerSpieler;
        }

    }
}
