﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInterface.Settings
{
    public static class ColorSettings
    {
        public static void ChangeColorScheme()
        {
            Console.Clear();
            Console.WriteLine("Select a color scheme:");
            Console.WriteLine("1. Default (Gray on Black)");
            Console.WriteLine("2. Light (White on Blue)");
            Console.WriteLine("3. Dark (Green on Black)");
            Console.WriteLine("4. High Contrast (Yellow on Black)");
            Console.WriteLine("5. Custom (You choose!)");
            Console.Write("\nEnter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        SetColorScheme(ConsoleColor.Gray, ConsoleColor.Black);
                        break;
                    case 2:
                        SetColorScheme(ConsoleColor.White, ConsoleColor.Blue);
                        break;
                    case 3:
                        SetColorScheme(ConsoleColor.Green, ConsoleColor.Black);
                        break;
                    case 4:
                        SetColorScheme(ConsoleColor.Yellow, ConsoleColor.Black);
                        break;
                    case 5:
                        CustomColorScheme();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Keeping current settings.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            Console.WriteLine("\nPress any key to return to the previous menu.");
            Console.ReadKey();
        }

        private static void SetColorScheme(ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Clear();
            Console.WriteLine($"Color scheme changed to: Foreground = {foreground}, Background = {background}");
        }

        private static void CustomColorScheme()
        {
            Console.Clear();
            Console.WriteLine("Enter the foreground color:");
            DisplayAvailableColors();
            if (!Enum.TryParse(Console.ReadLine(), true, out ConsoleColor foreground))
            {
                Console.WriteLine("Invalid color. Keeping current settings.");
                return;
            }

            Console.WriteLine("Enter the background color:");
            DisplayAvailableColors();
            if (!Enum.TryParse(Console.ReadLine(), true, out ConsoleColor background))
            {
                Console.WriteLine("Invalid color. Keeping current settings.");
                return;
            }

            SetColorScheme(foreground, background);
        }

        private static void DisplayAvailableColors()
        {
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.WriteLine($"- {color}");
            }
        }
    }
}
