using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    class Outfit
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public int Level { get; set; } = 1;
        public int HP { get; set; } = 100;
        public int CE_All { get; set; }
        public int TEN_All { get; set; }
        public bool CombatReady => HP > 0;


    }
}
