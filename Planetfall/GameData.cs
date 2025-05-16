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
    class GameData
    {
        public string PlayerName { get; set; }
        public string Faction { get; set; }
        public string Difficulty { get; set; }
        public Objective ActiveObjective { get; set; } = null;
        public int CurrentTurn { get; set; }
        public int MaxTurns { get; set; }
        public int Score { get; set; }
        public int Nanites { get; set; }
        public List<Continent> World { get; set; } = new();    
        public List<Outfit> Forces { get; set; } = new();
        public List<Outfit> EnemyPool { get; set; } = new();    
        public List<Outfit> ShopOutfits { get; set; } = new();
        public List<Favor> Support { get; set; } = new();
        public List<Objective> AllObjectives { get; set; } = new ();
        public List<Simulation> BattlePlans { get; set; } = new();
        public List<Simulation> EnemyPlans { get; set; } = new();
        public bool BastionDeployed { get; set; } = false;
        public bool DestroyedEnemy { get; set; } = false;
        // public Dictionary<(string Continent, string Lane), int> LockedLanes { get; set; } = new();
        public Dictionary<string, int> OutfitDeployment { get; set; } = new();
        // public Dictionary<(string continent, string lane), List<Outfit>> EnemyDeployment { get; set; } = new();
        public Dictionary<string, int> LockedLanes { get; set; } = new();        
        public Dictionary<string, List<Outfit>> EnemyDeployment { get; set; } = new();
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
                case "Qrf4": outfit.ComEffVsInf += 2; break;

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
        public static string MakeLaneKey(string continent, string lane) => $"{continent}-{lane}";

        public static (string Continent, string Lane) ParseLaneKey(string key)
        {
            var parts = key.Split('-');
            return (parts[0], parts[1]);
        }

    }
}
