using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    class Continent
    {
        public string Name { get; set; }
        public int PercentOwned { get; set; }
        public int ProgressLaneNorth { get; set; }
        public int ProgressLaneCentral { get; set; }
        public int ProgressLaneSouth { get; set; }
        public bool CentralLaneBonus { get; set; }
        public bool OwnWarpgateLost { get; set; }
        public bool NorthEnemyWarpgateCaptured { get; set; }
        public bool SouthEnemyWarpgateCaptured { get; set; }
        public bool Locked { get; set; } = false;
        public bool Captured { get; set; }

    }
}
