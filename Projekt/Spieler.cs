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


        public Spieler(string name, int gesundheit, int minSchaden, int maxSchaden, int maxGesundheit)
        {
            Name = name;
            Gesundheit = gesundheit;
            MinSchaden = minSchaden;
            MaxSchaden = maxSchaden;
            MaxGesundheit = maxGesundheit;
            Gold = 0;
        }


      


    }
}
