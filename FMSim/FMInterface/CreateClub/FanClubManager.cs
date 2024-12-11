using System.Text.RegularExpressions;
using FMBase.Clubs;
using FMBase.Hoomans;

namespace FMInterface.CreateClub;

    public static class FanClubManager
    {
        public static UserFanClub CreateClub()
        {
            Console.WriteLine("Enter the name of your club:");
            string name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter a description for your club:");
            string description = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter the basic colors of your club (in hexadecimal, e.g., #FF5733):");
            string colors = Console.ReadLine() ?? string.Empty;
            //string colors = GetValidatedColor(input); (WIP)
            
            Console.WriteLine("Enter the Number of Fans you want to join:");
            int fanCount = int.Parse(Console.ReadLine() ?? string.Empty);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("All fields must be filled. Please try again.");
                return null;
            }

            return new UserFanClub(name, description, colors, new Fan[fanCount]);
        }

        private static string GetValidatedColor(string color)
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                
                Regex hexColorRegex = new Regex(@"^#([A-Fa-f0-9]{6})$");

                if (hexColorRegex.IsMatch(input))
                {
                    string colorhex = input;
                    return colorhex;
                }
                else
                {
                    Console.WriteLine("Invalid color format. Please enter a valid hexadecimal color (e.g., #FF5733):");
                    string fixedHex = Console.ReadLine();
                    GetValidatedColor(fixedHex);
                }
            }
        }
    }
