using System;
using System.Collections.Generic;
using FMBase.Clubs;
using FMBase.ClubsTemp;
using FMBase.Hoomans;

namespace FMInterface.Actions
{
    public class MatchInterface
    {
        public static void PlayMatch()
        {
            // Tworzenie drużyn
            var club1 = FootballClubsTemp.Generate(true);
            var teamA = club1.Members;
            var club2 = FootballClubsTemp.Generate(false);
            var teamB = club2.Members;
            // Tworzenie meczu
            var match = new Match(teamA, teamB);
            

            Console.WriteLine("Welcome to the Football Match Simulator!");
            Console.WriteLine($"Team A: \"{club1.Name}\", Capitain is {teamA[10].Name}({teamA[10].Pos})");
            Console.WriteLine($"Team B: \"{club2.Name}\", Capitain is {teamB[10].Name}({teamB[10].Pos})");

            bool gameRunning = true;
            
            Random random = new Random();
            var Currentplayer = random.Next(teamA.Length);
            while (gameRunning)
            {
                Console.WriteLine($"\nCurrent Field: {match.CurrentField}");
                Console.WriteLine("Available actions:");

                // Wyświetlanie dostępnych opcji na podstawie CurrentField
                if (match.CurrentField == "A")
                {
                    Console.WriteLine("P. Pass");
                    Console.WriteLine("D. Dribble");
                    Console.WriteLine("R. Run");
                }
                else if (match.CurrentField == "B")
                {
                    Console.WriteLine("P. Pass");
                    Console.WriteLine("D. Dribble");
                    Console.WriteLine("S. Shoot");
                }
                else if (match.CurrentField == "C")
                {
                    Console.WriteLine("S. Shoot");
                }

                Console.WriteLine("L. Show Match Log");
                Console.WriteLine("Q. Exit");

                Console.Write("Your choice: ");
                var choice = Char.ToLower(Console.ReadKey().KeyChar);
                Console.Clear();
                
                
                switch (choice)
                {
                    case 'p':
                        if (match.CurrentField == "A")
                        {
                            Console.WriteLine(match.Pass(teamA[Currentplayer]));
                            Currentplayer = random.Next(3,6);
                        }
                        else if (match.CurrentField == "B")
                        {
                            Console.WriteLine(match.Pass(teamB[Currentplayer]));
                            Currentplayer = random.Next(0,3);
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case 'd':
                        if (match.CurrentField == "A")
                        {
                            Console.WriteLine(match.Dribble(teamA[Currentplayer], teamB[random.Next(3,6)]));
                        }
                        else if (match.CurrentField == "B")
                        {
                            Console.WriteLine(match.Dribble(teamA[Currentplayer], teamB[random.Next(6,10)]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case 'r':
                        if (match.CurrentField != "C" || match.CurrentField != "B")
                        {
                            Console.WriteLine(match.Run(teamA[Currentplayer], teamB[random.Next(3,6)]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case 's':
                        if (match.CurrentField == "B" || match.CurrentField == "C")
                        {
                            Console.WriteLine(match.Shoot(teamA[Currentplayer], teamB[10]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case 'l':
                        Console.WriteLine("\nMatch Log:");
                        Console.WriteLine(match.GetMatchLog());
                        break;
                    case 'q':
                        gameRunning = false;
                        Console.WriteLine("Exiting the game. Thank you for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    public class Match
    {
        public Player[] TeamA { get; private set; }
        public Player[] TeamB { get; private set; }
        public string CurrentField = "A"; // A: pole defensywne, B: środkowe, C: pole ofensywne
        public string MatchLog { get; private set; } = string.Empty;

        private Random random1 = new Random();

        public Match(Player[] teamA, Player[] teamB)
        {
            TeamA = teamA;
            TeamB = teamB;
        }

        public string Pass(Player player)
        {
            int passSkill = player.Passing + random1.Next(-10, 10);
            string result;

            if (passSkill >= 50)
            {
                result = $"{player.Name} successfully made a pass!";
                AdvanceField(); // Przesuwamy pole gry w stronę bramki przeciwnika
            }
            else
            {
                result = $"{player.Name} failed to make the pass!";
                RetreatField(); // Przeciwnik przejmuje piłkę i cofamy się
            }

            MatchLog += result + "\n";
            return result;
        }

        public string Defend(Player defender, Player attacker)
        {
            int defendSkill = defender.Defending + defender.Physical + random1.Next(-10, 10);
            int attackSkill = attacker.Dribbling + random1.Next(-10, 10);
            string result;

            if (defendSkill >= attackSkill)
            {
                result = $"{defender.Name} successfully stopped {attacker.Name}'s attack!";
                RetreatField(); // Obrona skuteczna, piłka cofa się
            }
            else
            {
                result = $"{attacker.Name} dribbled past {defender.Name}!";
                AdvanceField(); // Atakujący przechodzi dalej
            }

            MatchLog += result + "\n";
            return result;
        }

        public string Shoot(Player player, Player goalkeeper)
        {
            int shotSkill = player.Shooting + random1.Next(-20, 20);
            int goalkeepingSkill = goalkeeper.Defending + random1.Next(-20, 20);
            string result;

            if (shotSkill > goalkeepingSkill)
            {
                result = $"{player.Name} scored a goal!";
                ResetField(); // Resetujemy pole po zdobyciu bramki
            }
            else
            {
                result = $"{player.Name}'s shot was saved by {goalkeeper.Name}!";
                RetreatField(); // Piłka wraca w stronę pola środkowego
            }

            MatchLog += result + "\n";
            return result;
        }
        public string Run(Player player, Player defender)
        {
            int paceSkill = player.Run + random1.Next(-10, 10);
            int physicalSkill = defender.Physical + random1.Next(-10, 10);
            string result;

            if (paceSkill > physicalSkill)
            {
                result = $"{player.Name} outran {defender.Name}!";
                AdvanceField(); // Ucieczka udana, przesuwamy się do przodu
            }
            else
            {
                result = $"{player.Name} was stopped by {defender.Name}!";
                RetreatField(); // Zatrzymany, cofamy się
            }

            MatchLog += result + "\n";
            return result;
        }

        public string Dribble(Player player, Player defender)
        {
            int dribbleSkill = player.Dribbling + random1.Next(-10, 10);
            int defendSkill = defender.Defending + defender.Physical + random1.Next(-10, 10);
            string result;

            if (dribbleSkill > defendSkill)
            {
                result = $"{player.Name} successfully dribbled past {defender.Name}!";
                AdvanceField(); // Drybling udany, przesuwamy się do przodu
            }
            else
            {
                result = $"{player.Name} lost the ball to {defender.Name}!";
                RetreatField(); // Strata piłki, cofamy się
            }

            MatchLog += result + "\n";
            return result;
        }

        public string GetMatchLog()
        {
            return MatchLog;
        }

        private void AdvanceField()
        {
            if (CurrentField == "A")
                CurrentField = "B";
            else if (CurrentField == "B")
                CurrentField = "C";
        }

        private void RetreatField()
        {
            if (CurrentField == "C")
                CurrentField = "B";
            else if (CurrentField == "B")
                CurrentField = "A";
        }

        private void ResetField()
        {
            CurrentField = "A"; // Reset pola do środkowego po golu
        }
    }
}
