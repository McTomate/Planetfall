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
    class Continent
    {
        public string Name { get; set; }
        public int PercentOwned { get; set; }
        public int ProgressLaneNorth { get; set; }
        public int ProgressLaneCentral { get; set; }
        public int ProgressLaneSouth { get; set; }
        public int LockedTurnsRemaining { get; set; }
        public bool CentralLaneBonus { get; set; }
        public bool OwnWarpgateLost { get; set; }
        public bool NorthEnemyWarpgateCaptured { get; set; }
        public bool SouthEnemyWarpgateCaptured { get; set; }
        public bool Locked { get; set; } = false;
        public bool Captured { get; set; }
        public Dictionary<string, int> LockedLanes { get; set; } = new Dictionary<string, int>
        {
            { "North", 0 },
            { "Central", 0 },
            { "South", 0 }

        };
    }
}
