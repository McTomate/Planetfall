using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    class Simulation
    {
        public string ContinentName { get; set; }
        public string LaneName { get; set; }
        public List<Outfit> DeployedOutfits { get; set; } = new List<Outfit>();
    }
}
