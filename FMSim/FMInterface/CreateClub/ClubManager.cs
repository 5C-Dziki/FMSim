using System;
using System.Text.RegularExpressions;
using FMBase.Clubs;

namespace FMInterface.CreateClub
{
    public static class ClubManager
    {
        public static UserFootballClub CreateClub()
        {
            Console.WriteLine("Enter the name of your club:");
            string name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter a description for your club:");
            string description = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter the basic colors of your club (in hexadecimal, e.g., #FF5733):");
            string colors = GetValidatedColor();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("All fields must be filled. Please try again.");
                return null;
            }

            return new UserFootballClub(name, description, colors);
        }

        private static string GetValidatedColor()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                
                Regex hexColorRegex = new Regex(@"^#([A-Fa-f0-9]{6})$");

                if (hexColorRegex.IsMatch(input))
                {
                    string colorhex = input;
                }
                else
                {
                    Console.WriteLine("Invalid color format. Please enter a valid hexadecimal color (e.g., #FF5733):");
                }
            }
        }
    }
}