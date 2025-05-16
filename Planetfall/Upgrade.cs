using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

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
