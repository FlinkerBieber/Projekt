using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{


    internal class Gegner
    {
        public string Name { get; set; }
        public int Gesundheit { get; set; }
        public int Schaden { get; set; }

        public Gegner(string name, int gesundheit, int schaden)
        {
            Name = name;
            Gesundheit = gesundheit;
            Schaden = schaden;
        }


    }
}
