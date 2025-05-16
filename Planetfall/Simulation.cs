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
    class Simulation
    {
        public string ContinentName { get; set; }
        public string LaneName { get; set; }
        public List<Outfit> DeployedOutfits { get; set; } = new List<Outfit>();
        public Favor UsedFavor { get; set; }
    }
}
