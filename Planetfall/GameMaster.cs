using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Planetfall
{
    class GameMaster
    {

        private bool running = true;

        public void Start()
        {
            while (running)
            {
                MainMenu();
                string input = Console.ReadLine();
                NavMainMenu(input);
            }
        }

        private void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("[1] New Game");
            Console.WriteLine("[2] Load Game");
            Console.WriteLine("[3] Help");
            Console.WriteLine("[4] Exit Game");
        }


        private void NavMainMenu(string input)
        {
            switch (input.Trim())
            {
                case "1":
                    NewGame();
                    break;
                case "2":
                    LoadGame();
                    break;
                case "3":
                    Help();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }

        public static List<Outfit> GetStartOutfits(string faction, string diff)
        {
            var outfits = new List<Outfit>();

            switch (faction)
            {
                case "TR":
                    switch (diff)
                    {
                        case "Easy":
                            outfits.Add(new Outfit { Name = "TR Easy 1", Tag = "TRE1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Easy 2", Tag = "TRE2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Easy 3", Tag = "TRE3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Easy 4", Tag = "TRE4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Easy 5", Tag = "TRE5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Easy 6", Tag = "TRE6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Easy 7", Tag = "TRE7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                        case "Normal":
                            outfits.Add(new Outfit { Name = "TR Normal 1", Tag = "TRN1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Normal 2", Tag = "TRN2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Normal 3", Tag = "TRN3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Normal 4", Tag = "TRN4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Normal 5", Tag = "TRN5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Normal 6", Tag = "TRN6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Normal 7", Tag = "TRN7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                        case "Hard":
                            outfits.Add(new Outfit { Name = "TR Hard 1", Tag = "TRH1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Hard 2", Tag = "TRH2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Hard 3", Tag = "TRH3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Hard 4", Tag = "TRH4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Hard 5", Tag = "TRH5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Hard 6", Tag = "TRH6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "TR Hard 7", Tag = "TRH7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                    }
                    break;
                case "NC":
                    switch (diff)
                    {
                        case "Easy":
                            outfits.Add(new Outfit { Name = "NC Easy 1", Tag = "NCE1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Easy 2", Tag = "NCE2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Easy 3", Tag = "NCE3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Easy 4", Tag = "NCE4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Easy 5", Tag = "NCE5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Easy 6", Tag = "NCE6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Easy 7", Tag = "NCE7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                        case "Normal":
                            outfits.Add(new Outfit { Name = "NC Normal 1", Tag = "NCN1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Normal 2", Tag = "NCN2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Normal 3", Tag = "NCN3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Normal 4", Tag = "NCN4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Normal 5", Tag = "NCN5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Normal 6", Tag = "NCN6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Normal 7", Tag = "NCN7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                        case "Hard":
                            outfits.Add(new Outfit { Name = "NC Hard 1", Tag = "NCH1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Hard 2", Tag = "NCH2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Hard 3", Tag = "NCH3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Hard 4", Tag = "NCH4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Hard 5", Tag = "NCH5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Hard 6", Tag = "NCH6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "NC Hard 7", Tag = "NCH7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                    }
                    break;
                case "VS":
                    switch (diff)
                    {
                        case "Easy":
                            outfits.Add(new Outfit { Name = "VS Easy 1", Tag = "VSE1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Easy 2", Tag = "VSE2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Easy 3", Tag = "VSE3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Easy 4", Tag = "VSE4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Easy 5", Tag = "VSE5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Easy 6", Tag = "VSE6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Easy 7", Tag = "VSE7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                        case "Normal":
                            outfits.Add(new Outfit { Name = "VS Normal 1", Tag = "VSN1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Normal 2", Tag = "VSN2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Normal 3", Tag = "VSN3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Normal 4", Tag = "VSN4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Normal 5", Tag = "VSN5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Normal 6", Tag = "VSN6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Normal 7", Tag = "VSN7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                        case "Hard":
                            outfits.Add(new Outfit { Name = "VS Hard 1", Tag = "VSH1", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Hard 2", Tag = "VSH2", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Hard 3", Tag = "VSH3", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Hard 4", Tag = "VSH4", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Hard 5", Tag = "VSH5", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Hard 6", Tag = "VSH6", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            outfits.Add(new Outfit { Name = "VS Hard 7", Tag = "VSH7", Level = 2, HP = 10, CE_All = 2, TEN_All = 1 });
                            break;
                    }
                    break;
            }

            return outfits;
        }

        private GameData gameData;


        private void NewGame()
        {
            Console.Clear();



            /*
            Console.WriteLine("The year is 2855. It has been 10 years since the wormhole to Earth has closed and tensions between the factions have reached a breakpoint years ago. The planet of Auraxis has been devastated by constant warfare between three factions.\n");
            Console.Write("The authoritarian ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Terran Republic");
            Console.ResetColor();
            Console.WriteLine(", the challenged government of Auraxis, which strives to maintain peace and stability across the planet while searching for a way back to Earth - with little regard for individual and human rights in their quest.");
            Console.Write("The separatist ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("New Conglomerate");
            Console.ResetColor();
            Console.WriteLine(", a corporatist rebellion against the Terran Republic, fighting to ensure all people remain free from authoritarian rule - regardless of the cost to stability and prosperity.");
            Console.Write("The fanatic ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Vanu Soveignty");
            Console.ResetColor();
            Console.WriteLine(", religious technocrats, seeking the promised enlightenment of the Vanu alien race through the usage of their long lost relics and technology - performing human augmentation on the people of Auraxis in pursuit of this goal, consent be damned.\n");
            Console.WriteLine("You have proven yourself on the battlefield through superior squad based tactics and excellent leadership. Now the general staff has appointed you as the new prodigy commander to lead a handfull of outfits and to secure absolute victory. You are ready because failure is not an option!\n");
            */

            var intro = new List<(string Text, ConsoleColor? Color)>
            {
                ("The year is 2855. It has been 10 years since the wormhole to Earth has closed and tensions between the factions have reached a breakpoint years ago. The planet of Auraxis has been devastated by constant warfare between three factions.",null),
                ("\nThe authoritarian ", null),
                ("Terran Republic", ConsoleColor.Red),
                (", the challenged government of Auraxis, which strives to maintain peace and stability across the planet while searching for a way back to Earth - with little regard for individual and human rights in their quest.", null),
                ("\nThe separatist ",null),
                ("New Conglomerate",ConsoleColor.DarkBlue),
                (", a corporatist rebellion against the Terran Republic, fighting to ensure all people remain free from authoritarian rule - regardless of the cost to stability and prosperity.", null),
                ("\nThe fanatic ", null),
                ("Vanu Sovereignty",ConsoleColor.DarkMagenta),
                (", religious technocrats, seeking the promised enlightenment of the Vanu alien race through the usage of their long lost relics and technology - performing human augmentation on the people of Auraxis in pursuit of this goal, consent be damned.",null),
                ("\n\nYou have proven yourself on the battlefield through superior squad based tactics and excellent leadership. Now the general staff has appointed you as the new prodigy commander to lead a handful of outfits and to secure absolute victory. You are ready because failure is not an option!", null)

            };

            int linelength = 200;
            TextFormatting.FormattedText(intro, linelength);
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
            //Console.Clear();
            Console.WriteLine("\n-------------------\n");
            Console.Write("On the Battlefield you were called \"Napo\", short for \"Napoleon\" because of your tactical brilliance but in your new environment soldiers of lower rank greet you as: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Commander ");
            string username = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("\n-------------------\n");

            var flavorFactionSelect = new List<(string Text, ConsoleColor? Color)>
            {
                ("Like many others around you, you served in one of the many Mobile Infantry Battalions of the Terran Republic and went on the expedition through the mysterious wormhole leading into the unknown. After the arrival on Auraxis, amidst the rising tensions and the official secession of the New Conglomerate and Vanu Sovereignty you decided to...",null)
            };
            TextFormatting.FormattedText(flavorFactionSelect, linelength);
            //Console.WriteLine("Like many others around you, you served in one of the many Mobile Infantry Battalions of the Terran Republic and went on the expedition through the mysterious wormhole leading into the unknown. After the arrival on Auraxis, amidst the rising tensions and the official secession of the New Conglomerate and Vanu Sovereignty you decided to...");
            //Console.WriteLine("Choose your faction:\n");
            Console.Write("\n[1] ...renew your pledge of loyalty to the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Terran Republic (TR)");
            Console.ResetColor();
            Console.WriteLine(" - \"Loyalty Until Death, Strength In Unity\"");
            Console.Write("[2] ...fight for your rights and Freedom with the ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("New Conglomerate (NC)");
            Console.ResetColor();
            Console.WriteLine(" - \"Liberty or Death!\"");
            Console.Write("[3] ...embraced the truth of enlightenment from your new overlords in the ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Vanu Sovereignty (VS)");
            Console.ResetColor();
            Console.WriteLine(" - \"Technology Equals Might\"");
            string choiceFaction = Console.ReadLine();
            string faction;
            //Console.Clear();
            Console.WriteLine("\n-------------------\n");



            switch (choiceFaction.Trim())
            {
                case "1":
                    faction = "TR";
                    //Console.WriteLine("You were no fool to any delusions of freedom or enlightenment. You knew that what we need in times like these is unity. The NC and VS endanger this expedition and by extension all of humanity. Battle after battle, victory after victory, you rose in the ranks of the republican forces. Many medals and commendations later, you have finally been promoted to Commander. Your comrades in the field will miss you but they know that with you in the command center, you have a shot at total victory. They believe that you can finally end this war and allow us to find a way to reunite with our distant brothers and sisters back on Earth.");
                    //Console.WriteLine("You wake up from your daydream to a message on your console. It's the official message from the upper ranks.");
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("\nYou have been granted command over the superior forces of our republic! The brass has high expectations for you.");
                    //Console.ResetColor();
                    //Console.WriteLine("\nYou remember all the battles you went through. From the beaches of Oshur to the treacherous jungle of Hossin. You have been stuck in sieges for days or have seen them from afar from a bastion fleet carrier. You remember the sweet taste of your first victory and the bitter aftertaste of the first crushing defeat. Thinking back, you think the war you have fought so far was and will stay...");

                    TextFormatting.FormattedText("You were no fool to any delusions of freedom or enlightenment. You knew that what we need in times like these is unity. The NC and VS endanger this expedition and by extension all of humanity. Battle after battle, victory after victory, you rose in the ranks of the republican forces. Many medals and commendations later, you have finally been promoted to Commander. Your comrades in the field will miss you but they know that with you in the command center, you have a shot at total victory. They believe that you can finally end this war and allow us to find a way to reunite with our distant brothers and sisters back on Earth.", linelength);
                    TextFormatting.FormattedText("You wake up from your daydream to a message on your PDA. It's the official message from the upper ranks.", linelength);
                    TextFormatting.FormattedText("\nYou have been granted command over the superior forces of our republic! The brass has high expectations for you.\n", linelength, ConsoleColor.Red);
                    TextFormatting.FormattedText("You remember all the battles you went through. From the beaches of Oshur to the treacherous jungle of Hossin. You have been stuck in sieges for days or have seen them from afar from a bastion fleet carrier. You remember the sweet taste of your first victory and the bitter aftertaste of the first crushing defeat. Thinking back, you think the war you have fought so far was and will stay...", linelength);
                    break;
                case "2":
                    faction = "NC";
                    Console.WriteLine("PLACEHOLDER: FactionNC");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("You have been granted access to the best mercenaries money can buy! Perform well and the suits will give you a pay raise.");
                    Console.ResetColor();
                    break;
                case "3":
                    faction = "VS";
                    Console.WriteLine("PLACEHOLDER: FactionVS");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("The Vanu have chosen you to lead us to enlightenment! We have sacrificed to much to fail now.");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Invalid input. Press any key to try again...");
                    Console.ReadKey();
                    return;
            }

            // Placeholder - Update faction in Gamedata Class


            //Console.WriteLine("\nSelect difficulty:\n");
            Console.WriteLine("\n[1] ...Easy");
            Console.WriteLine("[2] ...Normal");
            Console.WriteLine("[3] ...Hard");
            string choiceDiff = Console.ReadLine();
            //Console.Clear();
            string diff = "";
            int nanites = 0;
            Console.WriteLine("\n-------------------\n");
            switch (choiceFaction)
            {
                case "1":
                    switch (choiceDiff.Trim())
                    {
                        case "1":
                            diff = "Easy";
                            nanites = 750;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Difficulty set to [Easy]\n\n");
                            Console.ResetColor();
                            TextFormatting.FormattedText("The war so far has been a walk in the park. So much so that you have often wondered how this conflict has dragged on for over 10 years. What were the Commanders actually doing? It doesn't matter now, for you will turn the tide and bring peace to Auraxis.", linelength);
                            TextFormatting.FormattedText("The brass has offered you a leadership position for many different fronts. You have decided to lead the next...", linelength);
                            break;
                        case "2":
                            diff = "Normal";
                            nanites = 500;
                            Console.WriteLine("Difficulty set to [Normal]");
                            Console.WriteLine("PLACEHOLDER: FactionTR - DiffNorm");
                            break;
                        case "3":
                            diff = "Hard";
                            nanites = 250;
                            Console.WriteLine("Difficulty set to [Hard]");
                            Console.WriteLine("PLACEHOLDER: FactionTR - DiffHard");
                            break;
                        default:
                            Console.WriteLine("Invalid input! Returning to main menu...");
                            Console.ReadKey();
                            return;
                    }
                    break;
                case "2":
                    switch (choiceDiff.Trim())
                    {
                        case "1":
                            diff = "Easy";
                            nanites = 750;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Difficulty set to [Easy]\n\n");
                            Console.ResetColor();
                            TextFormatting.FormattedText("The war so far has been a walk in the park. So much so that you have often wondered how this conflict has dragged on for over 10 years. What were the Commanders actually doing? It doesn't matter now, for you will turn the tide and bring peace to Auraxis.", linelength);
                            TextFormatting.FormattedText("The brass has offered you a leadership position for many different fronts. You have decided to lead the next...", linelength);
                            Console.WriteLine("PLACEHOLDER: FactionNC - DiffEasy");
                            break;
                        case "2":
                            diff = "Normal";
                            nanites = 500;
                            Console.WriteLine("Difficulty set to [Normal]");
                            Console.WriteLine("PLACEHOLDER: FactionNC - DiffNorm");
                            break;
                        case "3":
                            diff = "Hard";
                            nanites = 250;
                            Console.WriteLine("Difficulty set to [Hard]");
                            Console.WriteLine("PLACEHOLDER: FactionNC - DiffHard");
                            break;
                        default:
                            Console.WriteLine("Invalid input! Returning to main menu...");
                            Console.ReadKey();
                            return;
                    }
                    break;
                case "3":
                    switch (choiceDiff.Trim())
                    {
                        case "1":
                            diff = "Easy";
                            nanites = 750;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Difficulty set to [Easy]\n\n");
                            Console.ResetColor();
                            TextFormatting.FormattedText("The war so far has been a walk in the park. So much so that you have often wondered how this conflict has dragged on for over 10 years. What were the Commanders actually doing? It doesn't matter now, for you will turn the tide and bring peace to Auraxis.", linelength);
                            TextFormatting.FormattedText("The brass has offered you a leadership position for many different fronts. You have decided to lead the next...", linelength);
                            Console.WriteLine("PLACEHOLDER: FactionVS - DiffEasy");
                            break;
                        case "2":
                            diff = "Normal";
                            nanites = 500;
                            Console.WriteLine("Difficulty set to [Normal]");
                            Console.WriteLine("PLACEHOLDER: FactionVS - DiffNorm");
                            break;
                        case "3":
                            diff = "Hard";
                            nanites = 250;
                            Console.WriteLine("Difficulty set to [Hard]");
                            Console.WriteLine("PLACEHOLDER: FactionVS - DiffHard");
                            break;
                        default:
                            Console.WriteLine("Invalid input! Returning to main menu...");
                            Console.ReadKey();
                            return;
                    }
                    break;



            }



            //Console.WriteLine("\nSelect game length:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[0] DEMO: 2 turns\n");
            Console.ResetColor();
            Console.WriteLine("[1] ...Skirmish (10 turns)");
            Console.WriteLine("[2] ...Raid (20 turns)");
            Console.WriteLine("[3] ...Operation (35 turns)");
            Console.WriteLine("[4] ...Campaign (100 turns)");
            string gameLength = Console.ReadLine();
            string battleName = "";
            int maxTurns = 0;
            //Console.Clear();
            Console.WriteLine("\n-------------------\n");
            switch (choiceFaction)
            {
                case "1":
                    switch (gameLength)
                    {
                        case "0":
                            Console.WriteLine("PLACEHOLDER: FactionTR - LengthDemo");
                            Console.WriteLine("Game length set to 2 turns.");
                            battleName = "DEMO";
                            maxTurns = 2;
                            break;
                        case "1":
                            Console.WriteLine("PLACEHOLDER: FactionTR - LengthSkirmish");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Game length set to 10 turns.\n\n");
                            Console.ResetColor();
                            TextFormatting.FormattedText("A skirmish contesting multiple fronts on the continents of Indar, Esamir and Amerish will start soon and you have been appointed as commanding officer of all combat actions on those three continents. The Outfits that have been assigned to you have already reported in and are awaiting your first order.", linelength);
                            battleName = "Skirmish";
                            maxTurns = 10;
                            break;
                        case "2":
                            Console.WriteLine("PLACEHOLDER: FactionTR - LengthRaid");
                            Console.WriteLine("Game length set to 20 turns.");
                            battleName = "Raid";
                            maxTurns = 20;
                            break;
                        case "3":
                            Console.WriteLine("PLACEHOLDER: FactionTR - LengthOperation");
                            Console.WriteLine("Game length set to 35 turns.");
                            battleName = "Operation";
                            maxTurns = 35;
                            break;
                        case "4":
                            Console.WriteLine("PLACEHOLDER: FactionTR - LengthCampaign");
                            Console.WriteLine("Game length set to 100 turns.");
                            battleName = "Campaign";
                            maxTurns = 100;
                            break;
                        default:
                            Console.WriteLine("Invalid input! Returning to main menu...");
                            Console.ReadKey();
                            return;
                    }
                    break;
                case "2":
                    switch (gameLength)
                    {
                        case "0":
                            Console.WriteLine("PLACEHOLDER: FactionNC - LengthDemo");
                            Console.WriteLine("Game length set to 3 turns.");
                            battleName = "DEMO";
                            maxTurns = 3;
                            break;
                        case "1":
                            Console.WriteLine("PLACEHOLDER: FactionNC - LengthSkirmish");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Game length set to 10 turns.\n\n");
                            Console.ResetColor();
                            TextFormatting.FormattedText("A skirmish contesting multiple fronts on the continents of Indar, Esamir and Amerish will start soon and you have been appointed as commanding officer of all combat actions on those three continents. The Outfits that have been assigned to you have already reported in and are awaiting your first order.", linelength);
                            battleName = "Skirmish";
                            maxTurns = 10;
                            break;
                        case "2":
                            Console.WriteLine("PLACEHOLDER: FactionNC - LengthRaid");
                            Console.WriteLine("Game length set to 20 turns.");
                            battleName = "Raid";
                            maxTurns = 20;
                            break;
                        case "3":
                            Console.WriteLine("PLACEHOLDER: FactionNC - LengthOperation");
                            Console.WriteLine("Game length set to 35 turns.");
                            battleName = "Operation";
                            maxTurns = 35;
                            break;
                        case "4":
                            Console.WriteLine("PLACEHOLDER: FactionNC - LengthCampaign");
                            Console.WriteLine("Game length set to 100 turns.");
                            battleName = "Campaign";
                            maxTurns = 100;
                            break;
                        default:
                            Console.WriteLine("Invalid input! Returning to main menu...");
                            Console.ReadKey();
                            return;
                    }
                    break;
                case "3":
                    switch (gameLength)
                    {
                        case "0":
                            Console.WriteLine("Game length set to 3 turns.");
                            battleName = "DEMO";
                            maxTurns = 3;
                            break;
                        case "1":
                            Console.WriteLine("PLACEHOLDER: FactionVS - LengthSkirmish");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Game length set to 10 turns.\n\n");
                            Console.ResetColor();
                            TextFormatting.FormattedText("A skirmish contesting multiple fronts on the continents of Indar, Esamir and Amerish will start soon and you have been appointed as commanding officer of all combat actions on those three continents. The Outfits that have been assigned to you have already reported in and are awaiting your first order.", linelength);
                            battleName = "Skirmish";
                            maxTurns = 10;
                            break;
                        case "2":
                            Console.WriteLine("PLACEHOLDER: FactionVS - LengthRaid");
                            Console.WriteLine("Game length set to 20 turns.");
                            battleName = "Raid";
                            maxTurns = 20;
                            break;
                        case "3":
                            Console.WriteLine("PLACEHOLDER: FactionVS - LengthOperation");
                            Console.WriteLine("Game length set to 35 turns.");
                            battleName = "Operation";
                            maxTurns = 35;
                            break;
                        case "4":
                            Console.WriteLine("PLACEHOLDER: FactionVS - LengthCampaign");
                            Console.WriteLine("Game length set to 100 turns.");
                            battleName = "Campaign";
                            maxTurns = 100;
                            break;
                        default:
                            Console.WriteLine("Invalid input! Returning to main menu...");
                            Console.ReadKey();
                            return;
                    }
                    break;
            }
            Console.WriteLine("\nThe PDA displays a new message: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Initiating new {battleName}...\nWelcome Commander {username}.\nPlease report in to the situation room");
            Console.ResetColor();
            Console.WriteLine("\nPress any key to move to the situation room...");
            Console.ReadKey();
            Console.Clear();

            //Placeholder - Update max turns in GameData Class
            //Placeholder - JSON 

            // Placeholder - More flavor text on the way to the situation room for the first time
            /* switch(faction)
            case"NC":
            ...
            case"VS":
            ...
            case"TR":
            */
            TextFormatting.FormattedText("You leave your quarters and follow the signs towards your destination. On the way to the situation room you are greeted by your advisor \"Ender\". As you are new to the \"Orbital Command Station\", a senior officer has been assigned to you to help you with some administrative things.", linelength);
            TextFormatting.FormattedText($"Good afternoon {username}, it's time to make the republic proud. These traitors won't know what hit them.", linelength, ConsoleColor.DarkYellow);
            TextFormatting.FormattedText("When entering the situation room, you see a big hologlobe in the middle and lots of screens above it. The scene reminds you of pictures you have seen of the old stock markets. On these screens there is all relevant information for the general war effort. From the first glance you can tell that the war progress is inconclusive. All captured territory is lost on other fronts and vice versa. With three factions constantly exploiting eachothers weaknesses, a sort of eqilibrium has been achieved. Over the years many have tried to upset the balance but none have succeeded...so far that is.", linelength);
            Console.WriteLine("\nThere are many commanders present. Some are discussing the transfer of Outfits between eachother. Others are offering their help in turn for nanites, the universal resource here on Auraxis.");
            TextFormatting.FormattedText("Ender guides you to your seat. It's a state of the art terminal in which you can see a more detailed overview of your available resources and state of continents. Here you can plan the troop movements for the upcoming battle phase. You can also use the requisition module on here to buy upgrades for your Outfits. These will cost you nanites of which more will be allocated to you based on the territory you hold after the battle phase.", linelength);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            int score = 0;
            string obj = "";
            gameData = new GameData
            {
                PlayerName = username,
                Faction = faction,
                Difficulty = diff,
                ActiveObjective = obj,
                MaxTurns = maxTurns,
                Score = score,
                Nanites = nanites,
                World = new List<Continent>
                {
                    new Continent{Name="Indar",PercentOwned=(1/15),ProgressLaneNorth=(1/5),ProgressLaneCentral=(0/5),ProgressLaneSouth=(0 / 5),CentralLaneBonus=false,OwnWarpgateLost=false,NorthEnemyWarpgateCaptured=false,SouthEnemyWarpgateCaptured=false,Locked=false,Captured=false},
                    new Continent{Name="Esamir",PercentOwned=(1/15),ProgressLaneNorth=(1/5),ProgressLaneCentral=(0/5),ProgressLaneSouth=(0 / 5),CentralLaneBonus=false,OwnWarpgateLost=false,NorthEnemyWarpgateCaptured=false,SouthEnemyWarpgateCaptured=false,Locked=false,Captured=false},
                    new Continent{Name="Amerish",PercentOwned=(1/15),ProgressLaneNorth=(1/5),ProgressLaneCentral=(0/5),ProgressLaneSouth=(0 / 5),CentralLaneBonus=false,OwnWarpgateLost=false,NorthEnemyWarpgateCaptured=false,SouthEnemyWarpgateCaptured=false,Locked=false,Captured=false}
                },
                Forces = new List<Outfit>
                {

                },
                Support = new List<Favor>
                {

                },
            };
            gameData.Forces = GetStartOutfits(faction, diff);
            Console.Clear();
            SituationRoom();

        }

        private void SaveScumming()
        {

            bool running = true;
            while (running)
            {

                Console.Clear();
                Console.WriteLine("[1] Save Game");
                Console.WriteLine("[2] Load Game");
                Console.WriteLine("[3] Back to situation room\n\n");
                Console.WriteLine("[4] Main Menu");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SaveGame();
                        break;
                    case "2":
                        LoadGame();
                        break;
                    case "3":
                        running = false;
                        SituationRoom();
                        break;
                    case "4":
                        running = false;
                        return;
                    default:
                        Console.WriteLine("Invalid input! Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }

        }




        private void LoadGame()
        {
            Console.Clear();
            Console.WriteLine("Loading game...Welcome back Commander.");
            // Placeholder - JSON loading of GameData
            Console.WriteLine("PLACEHOLDER: JSON loading");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SaveGame()
        {
            Console.Clear();
            Console.WriteLine("Choose save file");
            // Placeholder - JSON saving of GameData
            Console.WriteLine("===========PLACEHOLDER===========");
            Console.WriteLine("[1] - Shepard - Terran Republic - Easy - Turn 10");
            Console.WriteLine("[2] - Garrus - New Conglomerate - Normal - Turn 4");
            Console.WriteLine("[3] - Tali - Vanu Soverignty - Hard - Turn 22");
            // Placeholder - confirm if overwrite
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        private void SituationRoom()
        {



            Console.Clear();
            Console.WriteLine("SITUATION ROOM");
            Console.WriteLine($"Turn 1 / X - [PLACEHOLDER: CurrentTurns / MaxTurns]"); // Placeholder - JSON implementation
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("Overview:\n");

            // Placeholder - JSON implementation with Dynamic data
            Console.WriteLine("PLACEHOLDER: Dynamic data");
            Console.WriteLine("Indar: 20%");
            Console.WriteLine("Esamir: 34%");
            Console.WriteLine("Amerish: 80%");
            Console.WriteLine("Nanites: 750");
            Console.WriteLine("Outfits: 7");
            Console.WriteLine("\n==========================================\n");

            // Placeholder - Pull Continent and Lane data from GameData Class
            // Placeholder - dynamic maps 
            Console.WriteLine("PLACEHOLDER: Dynamic maps");
            Console.WriteLine("Strategic map: Indar");
            Console.WriteLine("North:     [X]---[ ]---[ ]---[ ]---[ ]");
            Console.WriteLine("Central:   [X]---[ ]---[ ]---[ ]---[ ]");
            Console.WriteLine("South:     [X]---[ ]---[ ]---[ ]---[ ]");

            Console.WriteLine("\nStrategic map: Esamir");
            Console.WriteLine("North:     [X]---[X]---[X]---[ ]---[ ]");
            Console.WriteLine("Central:   [X]---[ ]---[ ]---[ ]---[ ]");
            Console.WriteLine("South:     [X]---[ ]---[ ]---[ ]---[ ]");

            Console.WriteLine("\nStrategic map: Amerish");
            Console.WriteLine("North:     [X]---[X]---[X]---[ ]---[ ]");
            Console.WriteLine("Central:   [X]---[X]---[X]---[X]---[ ]");
            Console.WriteLine("South:     [X]---[X]---[X]---[X]---[X]");

            Console.WriteLine("\n==========================================\n");

            Console.WriteLine("What will you do?\n");
            Console.WriteLine("[0] Menu");
            Console.WriteLine("[1] Diplomacy");
            Console.WriteLine("[2] Battle planning");
            Console.WriteLine("[3] End turn");
            string choice = Console.ReadLine();
            switch (choice.Trim())
            {
                case "0":
                    Console.Clear();
                    SaveScumming();
                    break;
                case "1":
                    Console.Clear();
                    DiplomacyMod();
                    break;
                case "2":
                    Console.Clear();
                    BattleMod();
                    break;
                case "3":
                    Console.Clear();
                    EndTurn();
                    break;
                default:
                    Console.WriteLine("Invalid input! Press any key to try again...");
                    Console.ReadKey();
                    break;
            }

        }

        private void DiplomacyMod()
        {
            bool running = true;

            while (running)
            {

                Console.Clear();

                Console.WriteLine("You join the negotiation with the other commanders.");

                Console.WriteLine("\nWhat will you do?\n");
                Console.WriteLine("[1] Side objectives");
                Console.WriteLine("[2] Request reinforcements");
                Console.WriteLine("[3] Back to situation room");
                string choice = Console.ReadLine();
                switch (choice.Trim())
                {
                    case "1":   //Placeholder - Side objectives
                                // Placeholder - Show active side objective
                                // Placeholder - Option 1: Select new objetive
                                // Placeholder - Option 2: Abort current objective
                                // Placeholder - Update Objectives in GameData Class
                        Console.WriteLine("PLACEHOLDER: Side objectives menu");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":   //Placeholder - Reinforcements
                                // Placeholder - Pull data from "Shop" List
                                // Placeholder - Option 1: Assume direct command of Outfits and add to available pool (direct control for the remainder of the game; expensive)
                                // Placeholder - Option 2: Coordinate with allied Commanders and "buy" their assistance (one time use to be deployed in the battle planning phase (Air support / Tank assault / Galaxy drop / MAX crash); cheaper)
                                // Placeholder - Update Reinforcement in GameData Class
                                // Placeholder - Update Outfit in GameData Class
                        Console.Clear();
                        Console.WriteLine("[1] Transfer Outfit to your command");
                        Console.WriteLine("[2] Purchase \"favors\"");
                        string input = Console.ReadLine();


                        switch (input)
                        {
                            case "1":
                                OutfitShop();
                                break;
                            case "2":
                                Console.WriteLine("placeholder");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Invalid input! Press any key to try again...");
                                break;
                        }

                        Console.WriteLine("PLACEHOLDER: Reinforcements \"shop\"");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        running = false;
                        SituationRoom();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Press any key to try again...");
                        Console.ReadKey();
                        break;

                }
            }
        }

        private List<Outfit> OutfitsForSale(string faction)
        {
            var outfits = new List<Outfit>();

            switch (faction)
            {
                case "TR":
                    outfits.Add(new Outfit { Name = "TR Extra 1", Tag = "TRX1", Faction = "TR" });
                    outfits.Add(new Outfit { Name = "TR Extra 2", Tag = "TRX2", Faction = "TR" });
                    break;
                case "NC":
                    outfits.Add(new Outfit { Name = "NC Extra 1", Tag = "NCX1", Faction = "NC" });
                    outfits.Add(new Outfit { Name = "NC Extra 2", Tag = "NCX2", Faction = "NC" });
                    break;
                case "VS":
                    outfits.Add(new Outfit { Name = "VS Extra 1", Tag = "VSX1", Faction = "VS" });
                    outfits.Add(new Outfit { Name = "VS Extra 2", Tag = "VSX2", Faction = "VS" });
                    break;
            }
            return outfits;
        }

        private void OutfitShop()
        {


            bool shopping = true;
            var options = OutfitsForSale(gameData.Faction);
            while (shopping)
            {
                Console.Clear();
                gameData.DisplayNanites();
                Console.WriteLine("\nChoose an Outfit to transfer:");
                Console.WriteLine("\n\n[0] Exit negotiations\n\n");




                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] - {options[i].Name} [{options[i].Tag}] - Cost: 200 Nanites");
                }

                string input = Console.ReadLine();

                if (input == "0")
                    shopping = false;
                else if (int.TryParse(input, out int index) && index > 0 && index <= options.Count)
                {
                    if (gameData.Nanites >= 200)
                    {
                        var chosen = options[index - 1];
                        gameData.Nanites -= 200;

                        chosen.Level = 1;
                        chosen.HP = 100;
                        chosen.CE_All = 20;
                        chosen.TEN_All = 10;

                        gameData.Forces.Add(chosen);

                        options.Remove(chosen);

                        Console.WriteLine($"Command over {chosen.Tag} has been transfered to you.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Nanites! Press any key to continue...");
                        Console.ReadKey();

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Press any key to try again...");
                    Console.ReadKey();
                }



            }
        }

        private void FavorShop()
        {
            bool shopping = true;

            var offers = new List<Favor>
            {
                new Favor { Name = "Galaxy Drop", Effect = "Light infantry air landing", Cost = 50 },
                new Favor { Name = "Artillery Barrage", Effect = "Armored convoy HE shelling", Cost = 50 },
                new Favor { Name = "MAX Crash", Effect = "Mechsuit infantry assault", Cost = 100 },
                new Favor { Name = "Fighter Wing Deployment", Effect = "Air-To-Air and Air-To-Ground support", Cost = 150 },
                new Favor { Name = "Railcannon Orbital Strike", Effect = "2t Orbital Strike striking at Mach60", Cost = 200 },
                new Favor { Name = "Bastion Fleet Carrier Deployment", Effect = "Flying carrier deploying all its air wings", Cost = 350 },
            };


            while (shopping)
            {

                Console.Clear();
                gameData.DisplayNanites();
                Console.WriteLine("\nChoose a Favor to purchase:");
                Console.WriteLine("\n\n[0] Exit shop\n\n");

                for (int i = 0; i < offers.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {offers[i].Name} - {offers[i].Cost} Nanites");
                }

                string input = Console.ReadLine();

                if (input == "0")
                    shopping = false;
                else if (int.TryParse(input, out int choice) && choice > 0 && choice <= offers.Count)
                {

                    var chosen = offers[choice - 1];

                    if (gameData.Nanites >= chosen.Cost)
                    {
                        gameData.Nanites -= chosen.Cost;
                        gameData.Support.Add(chosen);
                        Console.WriteLine($"You have aquired a new favor. Allied support in form of a \"{chosen.Name}\" can be requested at any time.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Nanites.");
                    }
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Invalid input! Press any key to try again...");
                    Console.ReadKey();
                }

            }
        }

        private void BattleMod()
        {
            //Placeholder - Battlemod
            bool running = true;

            while (running)
            {


                Console.Clear();

                Console.WriteLine("\nYou open your terminal.\n");

                Console.WriteLine("What will you do?\n");
                Console.WriteLine("[1] Battle planning");
                Console.WriteLine("[2] Upgrade Outfits");
                Console.WriteLine("[3] Back to situation room");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": // Placeholder - Pull Outfit, Continent, Lane, Reinforcements data from GameData Class
                              // Placeholder - Advisor recommending HVTs
                              // Placeholder - Choose continent
                              // Placeholder - Choose lane
                              // Placeholder - Assign Outfit
                              // Placeholder - Deploy reinforcements
                              //Placeholder - Update GameData Class
                        Console.WriteLine("PLACEHOLDER: Advisor recommendation ");
                        Console.WriteLine("PLACEHOLDER: Battle planning");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2": // Placeholder - Pull Outfit data from GameData Class

                        // Placeholder - Outfit Upgrades
                        // Placeholder - Modify Outfit data
                        // Placeholder - Update Outfit data in GameData
                        UpgradeShop();
                        //Console.WriteLine("PLACEHOLDER: Upgrade \"shop\"");
                        //Console.WriteLine("Press any key to continue...");
                        //Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        running = false;
                        SituationRoom();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }


        }

        private void UpgradeShop()
        {
            bool shopping = true;

            while (shopping)
            {
                Console.Clear();
                gameData.DisplayNanites();

                Console.WriteLine("\nChoose an Outfit to upgrade:");
                Console.WriteLine("\n\n[0] Exit shop\n\n");

                for (int i = 0; i < gameData.Forces.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {gameData.Forces[i].Name}");

                }
                string input = Console.ReadLine();

                if (input == "0")
                    shopping = false;

                else if (int.TryParse(input, out int index) && index > 0 && index <= gameData.Forces.Count)
                {
                    UpgradeOutfit(gameData.Forces[index - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid input! Press any key to try again...");
                    Console.ReadKey();
                }

            }
        }

        private void UpgradeOutfit(Outfit outfit)
        {
            bool upgrading = true;
            outfit.UpgradeForSale();
            while (upgrading)
            {
                Console.Clear();
                Console.WriteLine($"Selected Outfit: {outfit.Name}");
                gameData.DisplayNanites();
                Console.WriteLine("Select upgrade to purchase:");
                Console.WriteLine("\n\n[0] Exit shop\n\n");

                int i = 1;
                var availableUpgrades = outfit.Upgrades.Where(u => !u.Value.IsBought).ToList();

                foreach (var improvement in outfit.Upgrades.Where(u => u.Value.IsShown && !u.Value.IsBought))
                {
                    string status = improvement.Value.IsBought ? "[Bought]" : $"Cost: {improvement.Value.NaniteCost} Nanites";
                    Console.WriteLine($"[{i}] {improvement.Value.Name} ({improvement.Key}) - {status}");
                    i++;
                }

                string input = Console.ReadLine();

                if (input == "0")
                    upgrading = false;
                else if (int.TryParse(input, out int choice) && choice > 0 && choice <= outfit.Upgrades.Count)
                {
                    var key = availableUpgrades[choice - 1].Key;
                    gameData.BuyUpgrade(outfit, key);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input! Press any key to try again...");
                    Console.ReadKey();
                }
            }
        }

        private void EndTurn()
        {
            //Placeholder - WARNING: Unassigned outfits
            //Placeholder - NOTICE: Side objective available
            //Placeholder - Pull data from GameData Classe
            //Placeholder - Simulation
            //Placeholder - Results
            //Placeholder - Add resources based on territory after the simulation
            //Placeholder - Add Outfit XP
            //Placeholder - Score update in GameData Class
            //Placeholder - Turn update in GameData Class
            //Placeholder - Flavortext depending on simulation results and total points
            Console.WriteLine("PLACEHOLDER: Battle simulation, results, score and turn update, flavortext");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            SituationRoom();
        }

        private void CallSupport()
        {
            if (gameData.Support.Count == 0)
            {
                Console.WriteLine("No available favors.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Available favors:");

            for (int i = 0; i < gameData.Support.Count; i++)
            {
                Console.WriteLine($"[{i+1}] {gameData.Support[i].Name} - Effect: {gameData.Support[i].Effect}");

            }

            Console.WriteLine("\n\nChoose Favor to call in:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index > 0 && index <= gameData.Support.Count)
            {
                var favor = gameData.Support[index - 1];
                Console.WriteLine($"Favor: {favor.Name} will be called in to help in this battle.");


                //PLACEHOLDER Effect


                gameData.Support.RemoveAt(index - 1);
                Console.ReadKey();

            }



        }



        private void Help()
        {
            Console.Clear();
            //Placeholder - Help
            Console.WriteLine("PLACEHOLDER: How to play, outfits, resources, Lore");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

    }
}
