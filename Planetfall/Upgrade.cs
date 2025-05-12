using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    class Upgrade
    {
        public string Name { get; set; }
        public bool IsShown { get; set; }
        public bool IsBought { get; set; }
        public int LvlNeeded { get; set; }
        public int NaniteCost { get; set; }


        public Upgrade(string name, int lvlNeeded, int naniteCost)
        {
            Name = name;
            LvlNeeded = lvlNeeded;
            NaniteCost = naniteCost;
        }

    }
}
