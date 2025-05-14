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
        public int CurrentTurn { get; set; }
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
        public List<Favor> Support { get; set; }
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
        

        public void AddOutfit(Outfit outfit)
        {
            Forces.Add(outfit);
        }

        public bool BuyUpgrade(Outfit outfit, string upgradeTag)
        {
            if (!outfit.Upgrades.ContainsKey(upgradeTag))
            {
                Console.WriteLine("Upgrade not found.");
                return false;
            }


            var upgrade = outfit.Upgrades[upgradeTag];

            if (!upgrade.IsShown)
            {
                Console.WriteLine("The Outfit has not qualified for this Outfit yet.");
                return false;
            }

            if (upgrade.IsBought)
            {
                Console.WriteLine("Upgrade already bought.");
                return false;
            }

            if (Nanites < upgrade.NaniteCost)
            {
                Console.WriteLine("Insufficient Nanites.");
                return false;
            }

            Nanites -= upgrade.NaniteCost;
            upgrade.IsBought = true;


            switch (upgradeTag)
            {
                // BALANCING SUBJECT TO CHANGE
                case "Lvl1": outfit.ComEffVsAir += 1; break; 
                case "Lvl2": outfit.CE_All += 1; break;      
                case "Lvl3": outfit.TEN_All += 1; break;     

                
                case "Inf1": outfit.ComEffVsInf += 2; outfit.TenVsInf += 1; break; 
                case "Inf2": outfit.ComEffVsInf += 4; break;                       
                case "Inf3": outfit.ComEffVsAir += 3; break;                       
                case "Inf4": outfit.ComEffVsArm += 2; break;                       
                case "Inf5":
                    outfit.TEN_All += 2;                                           
                    outfit.ComEffVsAir += 2;
                    break;

                
                case "Arm1": outfit.TEN_All += 2; break;                           
                case "Arm2": outfit.ComEffVsInf += 2; break;                      
                case "Arm3":
                    switch (outfit.Faction)
                    {
                        case "TR": outfit.ComEffVsInf += 2; break;
                        case "NC": outfit.ComEffVsArm += 2; break;
                        case "VS":
                            outfit.TenVsInf += 1;
                            outfit.TenVsArm += 1;
                            break;
                    }
                    break; 
                case "Arm4": outfit.TenVsAir += 1; break;                          
                case "Arm5":
                    outfit.ComEffVsInf += 2;
                    outfit.ComEffVsArm += 2;
                    break; 

                
                case "Air1": outfit.TEN_All += 1; break;                           
                case "Air2": outfit.ComEffVsArm += 3; break;                       
                case "Air3":
                    outfit.ComEffVsArm += 3;
                    outfit.ComEffVsAir += 3;
                    outfit.ComEffVsInf -= 2;
                    break; 
                case "Air4": outfit.ComEffVsAir += 3; break;                       
                case "Air5":
                    outfit.TenVsInf += 3;
                    outfit.TenVsArm += 3;
                    break; 

                
                case "Qrf1": outfit.TenVsAir += 2; break;                          
                case "Qrf2": outfit.TEN_All += 1; break;                           
                case "Qrf3": outfit.ComEffVsInf += 2; break;                       

                default:
                    Console.WriteLine($"No stat effect defined for upgrade {upgradeTag}.");
                    break;
            }

            Console.WriteLine("Upgrade purchased.\n");
            Console.WriteLine($"New balance: {Nanites}");
            return true;

        }

        public void DisplayNanites()
        {
            Console.WriteLine($"Available Nanites: {Nanites}");
        }

        public void DisplayTurns()
        {
            Console.WriteLine($"Turn {CurrentTurn} / {MaxTurns}");
        }

        public void DisplayObjective()
        {
            Console.WriteLine($"Active side objective: {ActiveObjective}");
        }


    }
}
