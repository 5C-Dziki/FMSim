using System;
using System.Collections.Generic;
using FMBase.Hoomans;

namespace FMInterface.Actions
{
    public class MatchInterface
    {
        public static void PlayMatch()
        {
            // Tworzenie drużyn
            var teamA = new List<Player>
            {
                new Player(25, "Lionel Messi", 1.70f, 80, 90, 95, 60, 85, 95, "Forward"),
                new Player(28, "Sergio Ramos", 1.85f, 85, 70, 60, 90, 70, 60, "Defender")
            };

            var teamB = new List<Player>
            {
                new Player(30, "Cristiano Ronaldo", 1.87f, 90, 89, 93, 70, 78, 85, "Forward"),
                new Player(27, "Manuel Neuer", 1.93f, 85, 50, 60, 90, 60, 70, "Goalkeeper")
            };

            // Tworzenie meczu
            var match = new Match(teamA, teamB);

            Console.WriteLine("Welcome to the Football Match Simulator!");
            Console.WriteLine("Team A: Lionel Messi (Forward), Sergio Ramos (Defender)");
            Console.WriteLine("Team B: Cristiano Ronaldo (Forward), Manuel Neuer (Goalkeeper)\n");

            bool gameRunning = true;

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

                Console.WriteLine("5. Show Match Log");
                Console.WriteLine("6. Exit");

                Console.Write("Your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "P":
                        if (match.CurrentField != "C")
                        {
                            Console.WriteLine(match.Pass(teamA[0]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case "D":
                        if (match.CurrentField != "C")
                        {
                            Console.WriteLine(match.Dribble(teamA[0], teamB[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case "R":
                        if (match.CurrentField != "C" || match.CurrentField != "B")
                        {
                            Console.WriteLine(match.Run(teamA[0], teamB[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case "S":
                        if (match.CurrentField == "B" || match.CurrentField == "C")
                        {
                            Console.WriteLine(match.Shoot(teamA[0], teamB[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid action in this field.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nMatch Log:");
                        Console.WriteLine(match.GetMatchLog());
                        break;
                    case "6":
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
        public List<Player> TeamA { get; private set; }
        public List<Player> TeamB { get; private set; }
        public string CurrentField = "A"; // A: pole defensywne, B: środkowe, C: pole ofensywne
        public string MatchLog { get; private set; } = string.Empty;

        private Random random = new Random();

        public Match(List<Player> teamA, List<Player> teamB)
        {
            TeamA = teamA;
            TeamB = teamB;
        }

        public string Pass(Player player)
        {
            int passSkill = player.Passing + random.Next(-10, 10);
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
            int defendSkill = defender.Defending + defender.Physical + random.Next(-10, 10);
            int attackSkill = attacker.Dribbling + random.Next(-10, 10);
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
            int shotSkill = player.Shooting + random.Next(-20, 20);
            int goalkeepingSkill = goalkeeper.Defending + random.Next(-20, 20);
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
            int paceSkill = player.Run + random.Next(-10, 10);
            int physicalSkill = defender.Physical + random.Next(-10, 10);
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
            int dribbleSkill = player.Dribbling + random.Next(-10, 10);
            int defendSkill = defender.Defending + defender.Physical + random.Next(-10, 10);
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
