using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    class GameData
    {
        public string PlayerName { get; set; }
        public string Faction { get; set; }
        public string Difficulty { get; set; }
        public string ActiveObjective { get; set; }
        public int MaxTurns { get; set; }
        public int Score { get; set; }
        public int Nanites { get; set; }
        public List<Continent> World { get; set; }
        /*
        public int PercentIndar { get; set; }
        public int PercentEsamir { get; set; }
        public int PercentAmerish { get; set; }

        public int IndarLaneNorth { get; set; }
        public int IndarLaneCentral { get; set; }
        public int IndarLaneSouth { get; set; }

        public int EsamirLaneNorth { get; set; }
        public int EsamirLaneCentral { get; set; }
        public int EsamirLaneSouth { get; set; }

        public int AmerishLaneNorth { get; set; }
        public int AmerishLaneCentral { get; set; }
        public int AmerishLaneSouth { get; set; }

        public bool IndarLocked { get; set; }
        public bool EsamirLocked { get; set; }
        public bool AmerishLocked { get; set; }
        */
        public List<Outfit> Forces { get; set; }
        /*
        public string Name { get; set; }
        public string Tag { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public bool CombatReady => HP > 0;

        public int ComEffVsAll { get; set; }
        public int ComEffVsInf { get; set; }
        public int ComEffVsArm { get; set; }
        public int ComEffVsAir { get; set; }

        public int TenVsAll { get; set; }
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

        */
        public List<Reinforcement> Support { get; set; }
        /*
        public int AmountAirSupportRookie { get; set; }
        public int AmountAirSupportTrained { get; set; }
        public int AmountAirSupportElite { get; set; }

        public int AmountTankAssaultRookie { get; set; }
        public int AmountTankAssaultTrained { get; set; }
        public int AmountTankAssaultElite { get; set; }

        public int AmountGalDropRookie { get; set; }
        public int AmountGalDropTrained { get; set; }
        public int AmountGalDropElite { get; set; }

        public int AmountMaxCrashRookie { get; set; }
        public int AmountMaxCrashTrained { get; set; }
        public int AmountMaxCrashElite { get; set; }
        */




    }
}
