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
        public int XP { get; set; } = 0;
        public int Level { get; set; } = 1;
        public int HP { get; set; } = 100;
        public int CE_All { get; set; }
        public int TEN_All { get; set; }
        public bool CombatReady => HP > 0;

        // too much clutter --> create new Upgrade Class
        public int ComEffVsInf { get; set; } 
        public int ComEffVsArm { get; set; }
        public int ComEffVsAir { get; set; }

        
        public int TenVsInf { get; set; }
        public int TenVsArm { get; set; }
        public int TenVsAir { get; set; }

        public bool UpgradeLvl1 { get; set; }
        public bool UpgradeLvl2 { get; set; }
        public bool UpgradeLvl3 { get; set; }

        public bool SpecInf { get; set; }
        public bool SpecArm { get; set; }
        public bool SpecAir { get; set; }
        public bool SpecQrf { get; set; }

        public bool UpgradeInf1 { get; set; }
        public bool UpgradeInf2 { get; set; }
        public bool UpgradeInf3 { get; set; }
        public bool UpgradeInf4 { get; set; }
        public bool UpgradeInf5 { get; set; }

        public bool UpgradeArm1 { get; set; }
        public bool UpgradeArm2 { get; set; }
        public bool UpgradeArm3 { get; set; }
        public bool UpgradeArm4 { get; set; }
        public bool UpgradeArm5 { get; set; }

        public bool UpgradeAir1 { get; set; }
        public bool UpgradeAir2 { get; set; }
        public bool UpgradeAir3 { get; set; }
        public bool UpgradeAir4 { get; set; }
        public bool UpgradeAir5 { get; set; }

        public bool UpgradeQrf1 { get; set; }
        public bool UpgradeQrf2 { get; set; }
        public bool UpgradeQrf3 { get; set; }
        public bool UpgradeQrf4 { get; set; }
        public bool UpgradeQrf5 { get; set; }

        public void StatsUpgrade()
        {
            if (UpgradeLvl1)
                ComEffVsAir++;

            if (UpgradeLvl2)
                CE_All++;

            if (UpgradeLvl3)
                TEN_All++;

            



        }
    }
}
