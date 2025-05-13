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

        public int ComEffVsInf { get; set; }
        public int ComEffVsArm { get; set; }
        public int ComEffVsAir { get; set; }


        public int TenVsInf { get; set; }
        public int TenVsArm { get; set; }
        public int TenVsAir { get; set; }

        // too much clutter --> create Dictionary
        public string Spec { get; set; } = null;
        public void UpgradeForSale()
        {
            foreach (var upgrade in Upgrades.Values)
            {
                if (upgrade.LvlNeeded <= Level && (Spec == null || upgrade.Name.StartsWith(Spec)))
                {
                    upgrade.IsShown = true;
                }
            }
        }

        private void DisableOtherSpecs()
        {
            var allSpecs = new[] { "Inf", "Arm", "Air", "Qrf" };

            foreach (var upgrade in Upgrades.Values)
            {
                foreach (var otherSpec in allSpecs.Where(s => s != Spec))
                {
                    if (upgrade.Name.StartsWith(otherSpec))
                        upgrade.IsShown = false;
                }
            }

            if (Spec == "Air" || Spec == "Arm")
            {
                Upgrades["Lvl1"].IsShown = false;
                Upgrades["Lvl1"].IsBought = false;
                Upgrades["Lvl2"].IsShown = false;
                Upgrades["Lvl2"].IsBought = false;
                Upgrades["Lvl3"].IsShown = false;
                Upgrades["Lvl3"].IsBought = false;
            }
        }

        private void EnableSpecUpgrades()
        {
            foreach (var upgrade in Upgrades.Values)
            {
                if (upgrade.Name.StartsWith(Spec) && upgrade.LvlNeeded <= Level)
                    upgrade.IsShown = true;


            }
        }

        public void ChooseSpec(string spec)
        {
            Spec = spec;
            DisableOtherSpecs();
            EnableSpecUpgrades();
        }


        public Dictionary<string, Upgrade> Upgrades { get; set; } = new();

        public Outfit()
        {
            Upgrades["Lvl1"] = new Upgrade("Lvl1", 1, 25);
            Upgrades["Lvl2"] = new Upgrade("Lvl2", 2, 30);
            Upgrades["Lvl3"] = new Upgrade("Lvl3", 3, 50);

            Upgrades["Inf1"] = new Upgrade("Inf1", 4, 100);
            Upgrades["Inf2"] = new Upgrade("Inf2", 5, 100);
            Upgrades["Inf3"] = new Upgrade("Inf3", 5, 100);
            Upgrades["Inf4"] = new Upgrade("Inf4", 5, 100);
            Upgrades["Inf5"] = new Upgrade("Inf5", 6, 100);

            Upgrades["Arm1"] = new Upgrade("Arm1", 4, 100);
            Upgrades["Arm2"] = new Upgrade("Arm2", 5, 100);
            Upgrades["Arm3"] = new Upgrade("Arm3", 5, 100);
            Upgrades["Arm4"] = new Upgrade("Arm4", 5, 100);
            Upgrades["Arm5"] = new Upgrade("Arm5", 6, 100);

            Upgrades["Air1"] = new Upgrade("Air1", 4, 100);
            Upgrades["Air2"] = new Upgrade("Air2", 5, 100);
            Upgrades["Air3"] = new Upgrade("Air3", 5, 100);
            Upgrades["Air4"] = new Upgrade("Air4", 5, 100);
            Upgrades["Air5"] = new Upgrade("Air5", 6, 100);

            Upgrades["Qrf1"] = new Upgrade("Qrf1", 4, 100);
            Upgrades["Qrf2"] = new Upgrade("Qrf2", 5, 100);
            Upgrades["Qrf3"] = new Upgrade("Qrf3", 5, 100);
            Upgrades["Qrf4"] = new Upgrade("Qrf4", 5, 100);
            Upgrades["Qrf5"] = new Upgrade("Qrf5", 6, 100);
        }



    }
}
