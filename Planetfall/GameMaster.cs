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
    class GameMaster
    {

        private bool running = true;
        private GameData? gameData;
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
            string faction = "";
            string choiceFaction = "";
            string username = "";
            string choiceDiff = "";
            string diff = "";
            int nanites = 0;
            string battleName = "";
            int maxTurns = 0;





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
            username = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("\n-------------------\n");

            while (true)
            {

                TextFormatting.FormattedText("Like many others around you, you served in one of the many Mobile Infantry Battalions of the Terran Republic and went on the expedition through the mysterious wormhole leading into the unknown. After the arrival on Auraxis, amidst the rising tensions and the official secession of the New Conglomerate and Vanu Sovereignty you decided to...", linelength);

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
                choiceFaction = Console.ReadLine();

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
                        continue;
                }
                break;
            }

            bool check = true;
            while (check)
            {


                //Console.WriteLine("\nSelect difficulty:\n");
                Console.WriteLine("\n[1] ...Easy");
                Console.WriteLine("[2] ...Normal");
                Console.WriteLine("[3] ...Hard");
                choiceDiff = Console.ReadLine();
                //Console.Clear();


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
                                check = false;
                                break;
                            case "2":
                                diff = "Normal";
                                nanites = 500;
                                Console.WriteLine("Difficulty set to [Normal]");
                                Console.WriteLine("PLACEHOLDER: FactionTR - DiffNorm");
                                check = false;
                                break;
                            case "3":
                                diff = "Hard";
                                nanites = 250;
                                Console.WriteLine("Difficulty set to [Hard]");
                                Console.WriteLine("PLACEHOLDER: FactionTR - DiffHard");
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input! Returning to main menu...");
                                Console.ReadKey();
                                check = true;
                                continue;
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
                                check = false;
                                break;
                            case "2":
                                diff = "Normal";
                                nanites = 500;
                                Console.WriteLine("Difficulty set to [Normal]");
                                Console.WriteLine("PLACEHOLDER: FactionNC - DiffNorm");
                                check = false;
                                break;
                            case "3":
                                diff = "Hard";
                                nanites = 250;
                                Console.WriteLine("Difficulty set to [Hard]");
                                Console.WriteLine("PLACEHOLDER: FactionNC - DiffHard");
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input! Returning to main menu...");
                                Console.ReadKey();
                                check = true;
                                continue; ;
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
                                check = false;
                                break;
                            case "2":
                                diff = "Normal";
                                nanites = 500;
                                Console.WriteLine("Difficulty set to [Normal]");
                                Console.WriteLine("PLACEHOLDER: FactionVS - DiffNorm");
                                check = false;
                                break;
                            case "3":
                                diff = "Hard";
                                nanites = 250;
                                Console.WriteLine("Difficulty set to [Hard]");
                                Console.WriteLine("PLACEHOLDER: FactionVS - DiffHard");
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input! Returning to main menu...");
                                Console.ReadKey();
                                check = true;
                                continue; ;
                        }
                        break;



                }
                break;
            }

            check = true;

            while (check)
            {

                //Console.WriteLine("\nSelect game length:\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[0] DEMO: 2 turns\n");
                Console.ResetColor();
                Console.WriteLine("[1] ...Skirmish (10 turns)");
                Console.WriteLine("[2] ...Raid (20 turns)");
                Console.WriteLine("[3] ...Operation (35 turns)");
                Console.WriteLine("[4] ...Campaign (100 turns)");
                string gameLength = Console.ReadLine();

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
                                check = false;
                                break;
                            case "1":
                                Console.WriteLine("PLACEHOLDER: FactionTR - LengthSkirmish");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Game length set to 10 turns.\n\n");
                                Console.ResetColor();
                                TextFormatting.FormattedText("A skirmish contesting multiple fronts on the continents of Indar, Esamir and Amerish will start soon and you have been appointed as commanding officer of all combat actions on those three continents. The Outfits that have been assigned to you have already reported in and are awaiting your first order.", linelength);
                                battleName = "Skirmish";
                                maxTurns = 10;
                                check = false;
                                break;
                            case "2":
                                Console.WriteLine("PLACEHOLDER: FactionTR - LengthRaid");
                                Console.WriteLine("Game length set to 20 turns.");
                                battleName = "Raid";
                                maxTurns = 20;
                                check = false;
                                break;
                            case "3":
                                Console.WriteLine("PLACEHOLDER: FactionTR - LengthOperation");
                                Console.WriteLine("Game length set to 35 turns.");
                                battleName = "Operation";
                                maxTurns = 35;
                                check = false;
                                break;
                            case "4":
                                Console.WriteLine("PLACEHOLDER: FactionTR - LengthCampaign");
                                Console.WriteLine("Game length set to 100 turns.");
                                battleName = "Campaign";
                                maxTurns = 100;
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input! Returning to main menu...");
                                Console.ReadKey();
                                check = true;
                                continue;
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
                                check = false;
                                break;
                            case "1":
                                Console.WriteLine("PLACEHOLDER: FactionNC - LengthSkirmish");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Game length set to 10 turns.\n\n");
                                Console.ResetColor();
                                TextFormatting.FormattedText("A skirmish contesting multiple fronts on the continents of Indar, Esamir and Amerish will start soon and you have been appointed as commanding officer of all combat actions on those three continents. The Outfits that have been assigned to you have already reported in and are awaiting your first order.", linelength);
                                battleName = "Skirmish";
                                maxTurns = 10;
                                check = false;
                                break;
                            case "2":
                                Console.WriteLine("PLACEHOLDER: FactionNC - LengthRaid");
                                Console.WriteLine("Game length set to 20 turns.");
                                battleName = "Raid";
                                maxTurns = 20;
                                check = false;
                                break;
                            case "3":
                                Console.WriteLine("PLACEHOLDER: FactionNC - LengthOperation");
                                Console.WriteLine("Game length set to 35 turns.");
                                battleName = "Operation";
                                maxTurns = 35;
                                check = false;
                                break;
                            case "4":
                                Console.WriteLine("PLACEHOLDER: FactionNC - LengthCampaign");
                                Console.WriteLine("Game length set to 100 turns.");
                                battleName = "Campaign";
                                maxTurns = 100;
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input! Returning to main menu...");
                                Console.ReadKey();
                                check = true;
                                continue;
                        }
                        break;
                    case "3":
                        switch (gameLength)
                        {
                            case "0":
                                Console.WriteLine("Game length set to 3 turns.");
                                battleName = "DEMO";
                                maxTurns = 3;
                                check = false;
                                break;
                            case "1":
                                Console.WriteLine("PLACEHOLDER: FactionVS - LengthSkirmish");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Game length set to 10 turns.\n\n");
                                Console.ResetColor();
                                TextFormatting.FormattedText("A skirmish contesting multiple fronts on the continents of Indar, Esamir and Amerish will start soon and you have been appointed as commanding officer of all combat actions on those three continents. The Outfits that have been assigned to you have already reported in and are awaiting your first order.", linelength);
                                battleName = "Skirmish";
                                maxTurns = 10;
                                check = false;
                                break;
                            case "2":
                                Console.WriteLine("PLACEHOLDER: FactionVS - LengthRaid");
                                Console.WriteLine("Game length set to 20 turns.");
                                battleName = "Raid";
                                maxTurns = 20;
                                check = false;
                                break;
                            case "3":
                                Console.WriteLine("PLACEHOLDER: FactionVS - LengthOperation");
                                Console.WriteLine("Game length set to 35 turns.");
                                battleName = "Operation";
                                maxTurns = 35;
                                check = false;
                                break;
                            case "4":
                                Console.WriteLine("PLACEHOLDER: FactionVS - LengthCampaign");
                                Console.WriteLine("Game length set to 100 turns.");
                                battleName = "Campaign";
                                maxTurns = 100;
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input! Returning to main menu...");
                                Console.ReadKey();
                                check = true;
                                continue;
                        }
                        break;
                }
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
                CurrentTurn = 1,
                MaxTurns = maxTurns,
                Score = score,
                Nanites = nanites,
                World = new List<Continent>
                {
                    new Continent{Name="Indar",PercentOwned=(100/15),ProgressLaneNorth=(1),ProgressLaneCentral=(0),ProgressLaneSouth=(0),CentralLaneBonus=false,OwnWarpgateLost=false,NorthEnemyWarpgateCaptured=false,SouthEnemyWarpgateCaptured=false,Locked=false,Captured=false},
                    new Continent{Name="Esamir",PercentOwned=(200/15),ProgressLaneNorth=(0),ProgressLaneCentral=(2),ProgressLaneSouth=(0),CentralLaneBonus=false,OwnWarpgateLost=false,NorthEnemyWarpgateCaptured=false,SouthEnemyWarpgateCaptured=false,Locked=false,Captured=false},
                    new Continent{Name="Amerish",PercentOwned=(300/15),ProgressLaneNorth=(1),ProgressLaneCentral=(1),ProgressLaneSouth=(0),CentralLaneBonus=false,OwnWarpgateLost=false,NorthEnemyWarpgateCaptured=false,SouthEnemyWarpgateCaptured=false,Locked=false,Captured=false}
                },
                Forces = new List<Outfit>
                {

                },
                Support = new List<Favor>
                {

                },
            };
            gameData.ShopOutfits = OutfitsForSale(gameData.Faction);

            var allOutfits = GetStartOutfits(gameData.Faction, gameData.Difficulty);
            gameData.Forces = allOutfits.Take(7).ToList();

            gameData.EnemyPool = new List<Outfit>();

            foreach (var outfit in allOutfits)
            {
                if (outfit.Faction != gameData.Faction)
                {
                    gameData.EnemyPool.Add(outfit);
                }
            }

            gameData.Forces = GetStartOutfits(faction, diff);
            gameData.AllObjectives = CreateObjectives();
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

            Console.WriteLine("Choose a save slot to load:\n");

            for (int i = 1; i <= 3; i++)
            {
                string preview = GetSavePreview($"save{i}.json");
                Console.WriteLine($"[{i}] {preview}");
            }


            string? input = Console.ReadLine();

            string? filename = input switch
            {
                "1" => "save1.json",
                "2" => "save2.json",
                "3" => "save3.json",
                _ => null
            };

            if (filename == null)
            {
                Console.WriteLine("Invalid selection.");
                Console.ReadKey();
                return;
            }

            string fullPath = Path.Combine("Saves", filename);
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Save file not found.");
                Console.ReadKey();
                return;
            }

            gameData = JsonSerializer.Deserialize<GameData>(File.ReadAllText(fullPath));
            RebuildObjectiveConditions();

            Console.WriteLine("Loading game...Welcome back Commander.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            SituationRoom();
        }
        private void RebuildObjectiveConditions()
        {
            foreach (var obj in gameData.AllObjectives)
            {
                switch (obj.Name)
                {
                    case "Capture the Crown":
                        obj.Condition = g =>
                            g.World.FirstOrDefault(c => c.Name == "Indar")?.ProgressLaneCentral == 100;
                        break;

                    case "Destroy 1 enemy Outfit":
                        obj.Condition = g => g.Score >= 10;
                        break;

                    case "Capture 3 Bases":
                        obj.Condition = g =>
                            g.World.Sum(c => c.ProgressLaneNorth + c.ProgressLaneCentral + c.ProgressLaneSouth) >= 3;
                        break;

                    case "Deploy the Bastion Fleet Carrier":
                        obj.Condition = g => g.BastionDeployed;
                        break;

                    case "Fully capture 1 continent":
                        obj.Condition = g => g.World.Any(c => c.PercentOwned == 100);
                        break;

                    case "Have 1 Outfit reach level 6":
                        obj.Condition = g => g.Forces.Any(o => o.Level >= 6);
                        break;
                }
            }
        }
        private void SaveGame()
        {
            Console.Clear();
            Console.WriteLine("Choose save file");

            for (int i = 1; i <= 3; i++)
            {
                string preview = GetSavePreview($"save{i}.json");
                Console.WriteLine($"[{i}] {preview}");
            }

            string? input = Console.ReadLine();

            string? filename = input switch
            {
                "1" => "save1.json",
                "2" => "save2.json",
                "3" => "save3.json",
                _ => null
            };

            if (filename == null)
            {
                Console.WriteLine("Invalid selection.");
                Console.ReadKey();
                return;
            }

            Directory.CreateDirectory("Saves");
            string fullPath = Path.Combine("Saves", filename);
            string json = JsonSerializer.Serialize(gameData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fullPath, json);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private string GetSavePreview(string filename)
        {
            string fullPath = Path.Combine("Saves", filename);
            if (!File.Exists(fullPath)) return "[Empty]";

            try
            {
                var save = JsonSerializer.Deserialize<GameData>(File.ReadAllText(fullPath));
                return $"{save.PlayerName} - {save.Faction} - {save.Difficulty} - Turn {save.CurrentTurn}";
            }
            catch
            {
                return "[Corrupted Save]";
            }
        }
        private void SituationRoom()
        {



            Console.Clear();
            Console.WriteLine("SITUATION ROOM");
            Console.WriteLine($"Turn {gameData.CurrentTurn} / {gameData.MaxTurns}");
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("Overview:\n");

            // Placeholder - JSON implementation with Dynamic data
            //Console.WriteLine("PLACEHOLDER: Dynamic data");
            Console.WriteLine($"Indar: {gameData.World[0].PercentOwned}%");
            Console.WriteLine($"Esamir: {gameData.World[1].PercentOwned}%");
            Console.WriteLine($"Amerish: {gameData.World[2].PercentOwned}%");
            Console.WriteLine($"Nanites: {gameData.Nanites}");
            Console.WriteLine($"Outfits: {gameData.Forces.Count}");
            Console.WriteLine("\n==========================================\n");

            // Placeholder - Pull Continent and Lane data from GameData Class
            // Placeholder - dynamic maps 
            // Console.WriteLine("PLACEHOLDER: Dynamic maps");
            Console.WriteLine("Strategic map: Indar");
            DisplayLane("North", gameData.World[0].ProgressLaneNorth);
            DisplayLane("Central", gameData.World[0].ProgressLaneCentral);
            DisplayLane("South", gameData.World[0].ProgressLaneSouth);

            Console.WriteLine("\nStrategic map: Esamir");
            DisplayLane("North", gameData.World[1].ProgressLaneNorth);
            DisplayLane("Central", gameData.World[1].ProgressLaneCentral);
            DisplayLane("South", gameData.World[1].ProgressLaneSouth);

            Console.WriteLine("\nStrategic map: Amerish");
            DisplayLane("North", gameData.World[2].ProgressLaneNorth);
            DisplayLane("Central", gameData.World[2].ProgressLaneCentral);
            DisplayLane("South", gameData.World[2].ProgressLaneSouth);

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
        private void DisplayLane(string location, int progress)
        {
            Console.Write($"{location,-10}: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i < progress ? "[X]" : "[ ]");

                if (i < 4)
                    Console.Write("---");
            }
            Console.WriteLine();
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
                    case "1":   //Placeholder - Flavortext

                        ObjectiveManager();
                        break;
                    case "2":   //Placeholder - Flavortext
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
                                FavorShop();
                                break;
                            default:
                                Console.WriteLine("Invalid input! Press any key to try again...");
                                break;
                        }


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
        private List<Objective> CreateObjectives()
        {
            return new List<Objective>
    {
        new Objective
        {
            Name = "Capture the Crown",
            Details = "Secure the base called 'The Crown' on Indar.",
            Condition = gameData =>
                gameData.World.FirstOrDefault(c => c.Name == "Indar")?.ProgressLaneCentral == 100
        },
        new Objective
        {
            Name = "Destroy 1 enemy Outfit",
            Details = "Eliminate at least one enemy outfit in battle.",
            Condition = gameData => gameData.DestroyedEnemy=true
        },
        new Objective
        {
            Name = "Capture 3 Bases",
            Details = "Progress on any continent by 3 total sectors.",
            Condition = gameData =>
                gameData.World.Sum(Continent => Continent.ProgressLaneNorth + Continent.ProgressLaneCentral + Continent.ProgressLaneSouth) >= 3
        },
        new Objective
        {
            Name = "Deploy the Bastion Fleet Carrier",
            Details = "Call in the \"Bastion Fleet Carrier Deployment\" favor.",
            Condition = gameData => gameData.BastionDeployed
        },
        new Objective
        {
            Name = "Fully capture 1 continent",
            Details = "Any one continent must reach 100% control.",
            Condition = gameData => gameData.World.Any(Continent => Continent.PercentOwned == 100)
        },
        new Objective
        {
            Name = "Have 1 Outfit reach level 6",
            Details = "Train any outfit to level 6.",
            Condition = gameData => gameData.Forces.Any(Outfit => Outfit.Level >= 6)
        }
    };
        }
        private void ObjectiveManager()
        {
            Console.Clear();

            if (gameData.ActiveObjective == null)
            {
                Console.WriteLine("No side objective selected.\n");
                Console.WriteLine("Available objectives:\n");
                Console.WriteLine("\n[0] Back\n");
                for (int i = 0; i < gameData.AllObjectives.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {gameData.AllObjectives[i].Name} - {gameData.AllObjectives[i].Details}");
                }

                Console.Write("\nSelect an objective: ");
                string input = Console.ReadLine();

                if (input == "0")
                    return;

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= gameData.AllObjectives.Count)
                {
                    gameData.ActiveObjective = gameData.AllObjectives[choice - 1];
                    Console.WriteLine($"New objective: \"{gameData.ActiveObjective.Name}\" ");

                }
                else
                    Console.WriteLine("Invalid input! Press any key to try again...");
            }
            else
            {
                Console.WriteLine($"Current objective: \n\n >{gameData.ActiveObjective.Name}");
                Console.WriteLine($" > >{gameData.ActiveObjective.Details}");

                Console.WriteLine("\n\nChange objective? Y/N");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "y":
                        gameData.ActiveObjective = null;
                        ObjectiveManager();
                        break;
                    case "n":
                        return;
                    default:
                        Console.WriteLine("Invalid input! Press any key to try again...");
                        break;
                }


            }

            Console.ReadKey();

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
                new Favor { Name = "Railcannon Orbital Strike", Effect = "2-Ton projectile striking at Mach 60", Cost = 200 },
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
                        BattlePlanner();
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
        private void BattlePlanner()
        {
            
            bool planning = true;

            while (planning)
            {


                Console.Clear();
                CurrentPlan();
                Console.WriteLine("================PLANNING PHASE================\n\n");


                Console.WriteLine("Select continent:\n");
                Console.WriteLine("[0] Back\n");
                for (int i = 0; i < gameData.World.Count; i++)
                    Console.WriteLine($"[{i + 1}] {gameData.World[i].Name}");

                string input = Console.ReadLine();
                if (input == "0")
                {

                    planning = false;
                    continue;
                }

                if (!int.TryParse(input, out int contIndex) || contIndex < 1 || contIndex > gameData.World.Count)
                {
                    Console.WriteLine("Invalid input. Press any key...");
                    Console.ReadKey();
                    planning = false;
                    continue;
                }

                var continentChoice = gameData.World[contIndex - 1];

                if (continentChoice.Locked)
                {
                    Console.WriteLine($"{continentChoice.Name} is currently locked and cannot be contested.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"\n\n>{continentChoice.Name} selected");
                Console.WriteLine("\nSelect a lane:\n");
                Console.WriteLine("[0] Back\n");
                Console.WriteLine("[1] North");
                Console.WriteLine("[2] Central");
                Console.WriteLine("[3] South");

                input = Console.ReadLine();
                string laneChoice;


                switch (input)
                {
                    case "0":
                        planning = false;
                        continue;
                    case "1":
                        laneChoice = "North";
                        break;
                    case "2":
                        laneChoice = "Central";
                        break;
                    case "3":
                        laneChoice = "South";
                        break;
                    default:
                        laneChoice = null;
                        break;
                }


                if (laneChoice == null)
                {
                    Console.WriteLine("Invalid input. Press any key...");
                    Console.ReadKey();
                    planning = false;
                    continue;
                }

                if (gameData.LockedLanes.TryGetValue((continentChoice.Name, laneChoice), out int remaining) && remaining > 0)
                {
                    Console.WriteLine($"{continentChoice.Name} - {laneChoice} is currently locked and cannot be contested.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"\n\n> >{laneChoice} selected");
                Console.WriteLine($"\nSelect an outfit to deploy to {continentChoice.Name} - {laneChoice}:\n");

                Console.WriteLine("[0] Back\n");

                for (int i = 0; i < gameData.Forces.Count; i++)
                {
                    var Outfit = gameData.Forces[i];


                    int used = gameData.OutfitDeployment.ContainsKey(Outfit.Tag) ? gameData.OutfitDeployment[Outfit.Tag] : 0;
                    int max = Outfit.Spec == "Qrf" ? 2 : 1;


                    if (Outfit.Upgrades.ContainsKey("Qrf3") && Outfit.Upgrades["Qrf3"].IsBought) max++;
                    if (Outfit.Upgrades.ContainsKey("Qrf5") && Outfit.Upgrades["Qrf5"].IsBought) max++;

                    Console.WriteLine($"[{i + 1}] {Outfit.Name,-20} ({Outfit.Tag})  Used: {used}/{max}");
                }

                input = Console.ReadLine();

                if (input == "0")
                {

                    planning = false;
                    continue;
                }

                if (!int.TryParse(input, out int outfitIndex) || outfitIndex < 1 || outfitIndex > gameData.Forces.Count)
                {
                    Console.WriteLine("Invalid input. Press any key...");
                    Console.ReadKey();
                    planning = false;
                    continue;
                }


                var selectedOutfit = gameData.Forces[outfitIndex - 1];

                if (!gameData.OutfitDeployment.ContainsKey(selectedOutfit.Tag))
                    gameData.OutfitDeployment[selectedOutfit.Tag] = 0;

                int currentUses = gameData.OutfitDeployment[selectedOutfit.Tag];
                int maxUses = selectedOutfit.Spec == "Qrf" ? 2 : 1;

                if (selectedOutfit.Upgrades.ContainsKey("Qrf3") && selectedOutfit.Upgrades["Qrf3"].IsBought) maxUses++;
                if (selectedOutfit.Upgrades.ContainsKey("Qrf5") && selectedOutfit.Upgrades["Qrf5"].IsBought) maxUses++;

                if (currentUses >= maxUses)
                {
                    Console.WriteLine("Outfit has reached maximum deployments this turn.");
                    Console.ReadKey();
                    continue;
                }

                Simulation plan = null;

                foreach (var battle in gameData.BattlePlans)
                {
                    if (battle.ContinentName == continentChoice.Name && battle.LaneName == laneChoice)
                    {
                        plan = battle;
                        break;
                    }
                }

                if (plan == null)
                {
                    plan = new Simulation
                    {
                        ContinentName = continentChoice.Name,
                        LaneName = laneChoice
                    };

                    gameData.BattlePlans.Add(plan);
                }

                plan.DeployedOutfits.Add(selectedOutfit);
                gameData.OutfitDeployment[selectedOutfit.Tag]++;

                Console.WriteLine($"\n> > >{selectedOutfit.Name} assigned to {continentChoice.Name} - {laneChoice}.");

                if (gameData.Support.Count > 0 && plan.UsedFavor == null)
                {
                    Console.WriteLine("\nDo you want to call in a favor for this battle? (Y/N)");
                    string favorInput = Console.ReadLine().ToLower();
                    if (favorInput == "y")
                    {
                        CallSupport(plan);
                    }
                }
                continue;
            }
        }
        private void CurrentPlan()
        {
            Console.WriteLine("=== Current Battle Plan ===\n");


            Dictionary<string, Dictionary<string, List<Outfit>>> battleMap = new Dictionary<string, Dictionary<string, List<Outfit>>>();

            foreach (var sim in gameData.BattlePlans)
            {

                if (!battleMap.ContainsKey(sim.ContinentName))
                    battleMap[sim.ContinentName] = new Dictionary<string, List<Outfit>>();


                if (!battleMap[sim.ContinentName].ContainsKey(sim.LaneName))
                    battleMap[sim.ContinentName][sim.LaneName] = new List<Outfit>();


                battleMap[sim.ContinentName][sim.LaneName].AddRange(sim.DeployedOutfits);
            }


            foreach (var continentEntry in battleMap)
            {
                string continent = continentEntry.Key;

                foreach (var laneEntry in continentEntry.Value)
                {
                    string lane = laneEntry.Key;
                    List<Outfit> outfits = laneEntry.Value;

                    Console.WriteLine($"{continent} - {lane}:");

                    if (outfits.Count == 0)
                    {
                        Console.WriteLine("  (none)");
                    }
                    else
                    {
                        foreach (var outfit in outfits)
                        {
                            Console.WriteLine($"  - {outfit.Tag} ({outfit.Name})");
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("===========================\n");
        }
        private void CallSupport(Simulation plan)
        {
            if (gameData.Support.Count == 0)
            {
                Console.WriteLine("No available favors.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Available favors:");

            Console.WriteLine("[0] Back");

            for (int i = 0; i < gameData.Support.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {gameData.Support[i].Name} - Effect: {gameData.Support[i].Effect}");

            }

            Console.WriteLine("\n\nChoose Favor to call in:");

            string input = Console.ReadLine();

            if (input == "0")
                return;

            if (int.TryParse(input, out int index) && index > 0 && index <= gameData.Support.Count)
            {
                var favor = gameData.Support[index - 1];
                plan.UsedFavor = favor;

                Console.WriteLine($"Favor: {favor.Name} will be called in to help in this battle.");


                gameData.Support.RemoveAt(index - 1);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid input! Press any key to continue...");
                Console.ReadKey();
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
            int totalEnemyOutfits = gameData.Forces.Count + gameData.Difficulty switch
            {
                "Easy" => 0,
                "Normal" => 1,
                "Hard" => 2,
                _ => 1
            };
            gameData.EnemyDeployment = DistributeEnemyOutfits(totalEnemyOutfits);

            foreach (var battle in gameData.BattlePlans)
            {
                var continent = gameData.World.First(Continent => Continent.Name == battle.ContinentName);

                List<Outfit> playerOutfits = battle.DeployedOutfits;
                List<Outfit> enemyOutfits = GenerateEnemyOutfits(continent, battle.LaneName);

                int playerCE = 0;
                int playerTEN = 0;
                foreach (var Outfit in playerOutfits)
                {
                    playerCE += Outfit.ComEffVsInf + Outfit.ComEffVsArm + Outfit.ComEffVsAir;
                    playerTEN += Outfit.TenVsInf + Outfit.TenVsArm + Outfit.TenVsAir;
                }

                int enemyCE = 0;
                int enemyTEN = 0;
                foreach (var Outfit in enemyOutfits)
                {
                    enemyCE += Outfit.ComEffVsInf + Outfit.ComEffVsArm + Outfit.ComEffVsAir;
                    enemyTEN += Outfit.TenVsInf + Outfit.TenVsArm + Outfit.TenVsAir;
                }


                if (battle.UsedFavor != null)
                {
                    string favorName = battle.UsedFavor.Name;
                    switch (favorName)
                    {
                        case "Galaxy Drop":
                            playerCE += 10;
                            break;
                        case "MAX Crash":
                            playerCE += 10;
                            break;
                        case "Artillery Barrage":
                            playerCE += 10;
                            break;
                        case "Fighter Wing Deployment":
                            playerCE += 15;
                            break;
                        case "Railcannon Orbital Strike":
                            enemyTEN = 0;
                            break;
                        case "Bastion Fleet Carrier Deployment":
                            enemyTEN = 0;
                            playerCE = 999;
                            break;
                    }

                    gameData.Support.Remove(battle.UsedFavor);
                }

                int playerDamageTaken = Math.Max(0, enemyCE - playerTEN);
                int enemyDamageTaken = Math.Max(0, playerCE - enemyTEN);

                if (enemyDamageTaken > 10)
                {
                    gameData.DestroyedEnemy = true;
                }

                bool playerWins = enemyOutfits.Count == 0 || playerDamageTaken < enemyDamageTaken;


                foreach (var Outfit in playerOutfits)
                {
                    Outfit.XP += playerWins ? 20 : 10;
                    if (Outfit.XP >= 100)
                    {
                        Outfit.Level++;
                        Outfit.XP = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{Outfit.Name} ({Outfit.Tag}) has reached Level {Outfit.Level}!");
                        Console.ResetColor();
                    }
                }


                if (playerWins)
                {
                    IncreaseLaneProgress(continent, battle.LaneName);

                    int progress = GetLaneProgress(continent, battle.LaneName);
                    if (progress >= 5)
                    {
                        LockLane(continent, battle.LaneName, 4);
                        SetLaneProgress(continent, battle.LaneName, 3);
                    }
                }
                else
                {
                    DecreaseLaneProgress(continent, battle.LaneName);

                    int progress = GetLaneProgress(continent, battle.LaneName);
                    if (progress <= 0)
                    {
                        LockLane(continent, battle.LaneName, 4);
                        SetLaneProgress(continent, battle.LaneName, 1);
                    }
                }



                Console.WriteLine($"Battle on {continent.Name} - {battle.LaneName}: {(playerWins ? "Victory" : "Defeat")}\n");
            }

            foreach (var continent in gameData.World)
            {
                if (continent.ProgressLaneNorth >= 5 && continent.ProgressLaneCentral >= 5 && continent.ProgressLaneSouth >= 5 && !continent.Locked)
                {
                    Console.WriteLine($"{continent.Name} is now fully under your control and locked for 6 turns!");
                    continent.Locked = true;
                    continent.LockedTurnsRemaining = 6;
                    gameData.Score += 50;
                }
            }

            UpdateVictoryPoints();
            AwardNanites();

            if (gameData.ActiveObjective != null && gameData.ActiveObjective.Condition(gameData))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nObjective \"{gameData.ActiveObjective.Name}\" completed!");
                Console.ResetColor();

                gameData.Nanites += 100;
                gameData.Score += 25;

                Console.WriteLine("Reward: +100 Nanites, +25 Score.");
                gameData.ActiveObjective = null;
            }

            gameData.BattlePlans.Clear();
            gameData.OutfitDeployment.Clear();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            UpdateLaneLocks();
            UpdateContinentLocks();
            gameData.CurrentTurn++;
            CheckEndGameConditions();
            SituationRoom();
        }
        private Dictionary<(string continent, string lane), List<Outfit>> DistributeEnemyOutfits(int totalEnemyOutfits)
        {
            Dictionary<(string, string), List<Outfit>> deployment = new();
            List<Outfit> pool = new List<Outfit>(gameData.EnemyPool);
            Random rng = new();


            List<(string continent, string lane)> lanes = new();
            foreach (var continent in gameData.World)
            {
                if (continent.Locked) continue;

                if (!gameData.LockedLanes.ContainsKey((continent.Name, "North")))
                    lanes.Add((continent.Name, "North"));
                if (!gameData.LockedLanes.ContainsKey((continent.Name, "Central")))
                    lanes.Add((continent.Name, "Central"));
                if (!gameData.LockedLanes.ContainsKey((continent.Name, "South")))
                    lanes.Add((continent.Name, "South"));
            }


            for (int i = 0; i < totalEnemyOutfits && pool.Count > 0; i++)
            {
                int laneIndex = rng.Next(lanes.Count);
                var lane = lanes[laneIndex];

                if (!deployment.ContainsKey(lane))
                    deployment[lane] = new List<Outfit>();

                int outfitIndex = rng.Next(pool.Count);
                deployment[lane].Add(pool[outfitIndex]);
                pool.RemoveAt(outfitIndex);
            }

            return deployment;
        }
        private List<Outfit> GenerateEnemyOutfits(Continent continent, string lane)
        {
            var key = (continent.Name, lane);
            if (gameData.EnemyDeployment.ContainsKey(key))
                return gameData.EnemyDeployment[key];
            else
                return new List<Outfit>();
        }
        private void LockLane(Continent continent, string lane, int duration)
        {
            gameData.LockedLanes[(continent.Name, lane)] = duration;
            Console.WriteLine($"{continent.Name} - {lane} has been locked down. Further combat operations are unavailable until further notice.");
        }
        private int GetLaneProgress(Continent continent, string lane)
        {
            switch (lane)
            {
                case "North":
                    return continent.ProgressLaneNorth;
                case "Central":
                    return continent.ProgressLaneCentral;
                case "South":
                    return continent.ProgressLaneSouth;
                default:
                    return 0;
            }
        }
        public void SetLaneProgress(Continent continent, string lane, int value)
        {
            switch (lane)
            {
                case "North":
                    continent.ProgressLaneNorth = value;
                    break;
                case "Central":
                    continent.ProgressLaneCentral = value;
                    break;
                case "South":
                    continent.ProgressLaneSouth = value;
                    break;
            }

        }
        private void IncreaseLaneProgress(Continent continent, string lane)
        {
            int progress = GetLaneProgress(continent, lane);
            SetLaneProgress(continent, lane, Math.Min(progress + 1, 5));
        }
        private void DecreaseLaneProgress(Continent continent, string lane)
        {
            int progress = GetLaneProgress(continent, lane);
            SetLaneProgress(continent, lane, Math.Max(progress - 1, 0));
        }
        private void UpdateLaneLocks()
        {
            var updated = new Dictionary<(string, string), int>();

            foreach (var entry in gameData.LockedLanes)
            {
                int newTurns = entry.Value - 1;
                if (newTurns > 0)
                {
                    updated[entry.Key] = newTurns;
                }
                else
                {
                    Console.WriteLine($"{entry.Key.Item1} - {entry.Key.Item2} is now unlocked. Push them back!");
                }
            }

            gameData.LockedLanes = updated;
        }
        private void UpdateContinentLocks()
        {
            foreach (var continent in gameData.World)
            {
                if (continent.Locked)
                {
                    continent.LockedTurnsRemaining--;

                    if (continent.LockedTurnsRemaining <= 0)
                    {
                        continent.Locked = false;
                        Console.WriteLine($"{continent.Name} has been unlocked. Resume combat operations!");

                    }
                    else
                    {
                        Console.WriteLine($"Turns until {continent.Name} is unlocked: {continent.LockedTurnsRemaining}");
                    }
                }
            }
        }
        private void AwardNanites()
        {
            int nanitesPerBase = 10;
            int totalBasesControlled = 0;
            float modifier = gameData.Difficulty switch
            {
                "Easy" => 1.2f,
                "Normal" => 1.0f,
                "Hard" => 0.8f,
                _ => 1.0f
            };


            foreach (var continent in gameData.World)
            {
                int totalProgress = continent.ProgressLaneNorth + continent.ProgressLaneCentral + continent.ProgressLaneSouth;
                totalBasesControlled += totalProgress;
            }
            int nanitesGained = (int)(totalBasesControlled * nanitesPerBase * modifier);

            gameData.Nanites += nanitesGained;

            Console.WriteLine($"You have recieved {nanitesGained} Nanites from held territory.");
        }
        private void UpdateVictoryPoints()
        {
            int previousScore = gameData.Score;
            int turnPoints = 0;

            foreach (var continent in gameData.World)
            {
                turnPoints += continent.ProgressLaneNorth;
                turnPoints += continent.ProgressLaneCentral;
                turnPoints += continent.ProgressLaneSouth;


                turnPoints -= CountGhostCaps(continent, "North");
                turnPoints -= CountGhostCaps(continent, "Central");
                turnPoints -= CountGhostCaps(continent, "South");
            }

            gameData.Score += turnPoints;
            int diff = gameData.Score - previousScore;

            if (diff >= 0)
                Console.WriteLine($"You gained {diff} Victory Points this turn.");
            else
                Console.WriteLine($"You lost {Math.Abs(diff)} Victory Points this turn.");
        }

        private Dictionary<(string continent, string lane), int> ghostCapCounter = new();
        private int CountGhostCaps(Continent continent, string lane)
        {
            var key = (continent.Name, lane);

            bool playerDefended = gameData.BattlePlans.Any(b => b.ContinentName == continent.Name && b.LaneName == lane);
            int progress = GetLaneProgress(continent, lane);

            if (progress == 0 && !playerDefended)
            {
                if (!ghostCapCounter.ContainsKey(key))
                    ghostCapCounter[key] = 1;
                else
                    ghostCapCounter[key]++;

                if (ghostCapCounter[key] >= 2)
                {
                    Console.WriteLine($"Penalty: {continent.Name} - {lane} was ignored {ghostCapCounter[key]} times.");
                    return 3;
                }
            }
            else
            {
                if (ghostCapCounter.ContainsKey(key))
                    ghostCapCounter[key] = 0;
            }

            return 0;
        }
        private void CheckEndGameConditions()
        {
            bool allContinentLocked = gameData.World.All(c => c.Locked);
            bool maxTurnsReached = gameData.CurrentTurn >= gameData.MaxTurns;

            if (allContinentLocked || maxTurnsReached)
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("Mission Complete!");

                int finalScore = gameData.Score;

                if (allContinentLocked)
                {
                    finalScore *= 2;
                    Console.WriteLine("All continents have been conquered! Final score doubled.");
                }

                Console.WriteLine($"Final Score: {finalScore}");
                Console.WriteLine("--------------------\n");

                Console.WriteLine("Press any key to return to main menu...");
                Console.ReadKey();
                MainMenu();
            }
        }

        private void Help()
        {
            Console.Clear();
            Console.WriteLine("[0] Back");
            Console.WriteLine("[1] How to play");
            Console.WriteLine("[2] Outfits");
            Console.WriteLine("[3] Lore");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1"://PLACEHOLDER
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

    }
}
