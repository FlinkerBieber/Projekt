using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Spieler
    {
        public string Name { get; set; }
        public int Gesundheit { get; set; }

        public int MaxGesundheit { get; set; }
        public int Schaden { get; set; }
        public int Inventarplaetze { get; set; }
        public int MinSchaden { get; set; }
        public int MaxSchaden { get; set; }
        public bool HeilungBenutzt { get; set; } = false;
        public int Gold {  get; set; }

        public int Level = 1;

        public int GegnerGetoetet { get; set; } = 0;


        public Spieler(string name, int gesundheit, int minSchaden, int maxSchaden, int maxGesundheit)
        {
            Name = name;
            Gesundheit = gesundheit;
            MinSchaden = minSchaden;
            MaxSchaden = maxSchaden;
            MaxGesundheit = maxGesundheit;
            Gold = 0;
            GegnerGetoetet = 0;
            Level = 1;
        }


        public void LevelUp()
        {
            Level++;
            MaxGesundheit += 15;
            Gesundheit += 15;
            MinSchaden += 10;
            MaxSchaden += 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n LEVEL UP! Du bist jetzt Level {Level}!");
            Console.WriteLine("Gesundheit und Schaden wurden erhöht.\n");
            Console.ResetColor();
        }
        public void ZeigeStats()
        {
            Console.WriteLine("\n--- Spielerstatus ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gesundheit: {Gesundheit} / {MaxGesundheit}");
            Console.WriteLine($"Schaden: {MinSchaden} - {MaxSchaden}");
            Console.WriteLine($"Gold: {Gold}");
            Console.WriteLine($"Inventarplätze: {Inventarplaetze}");
            Console.WriteLine($"Gegner besiegt: {GegnerGetoetet}");
            Console.WriteLine("----------------------\n");
        }

    }
}
