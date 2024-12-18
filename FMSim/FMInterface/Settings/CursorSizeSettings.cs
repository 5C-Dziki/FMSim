﻿
namespace FMInterface.Settings
{
    public static class CursorSizeSettings
    {
        public static void ChangeCursorSize()
        {
            Console.Clear();
            Console.WriteLine("Select a Cursor Size:");
            Console.WriteLine("1. Large");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Thin");
            Console.WriteLine("4. Custom (You choose!)");
            Console.Write("\nEnter your choice: ");

            var input = Console.ReadKey().KeyChar;
            int choice;
            if (Char.IsNumber(input))
            {
                choice = (int)Char.GetNumericValue(input);
            }
            else
            {
                choice = -1;
            }
            Console.WriteLine();

            try
            {
                switch (choice)
                {
                    case 1:
                        SetCursorSize(100);
                        break;
                    case 2:
                        SetCursorSize(50);
                        break;
                    case 3:
                        SetCursorSize(15);
                        break;
                    case 4:
                        CustomCursorSize();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Keeping current settings.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nPress any key to return to the previous menu.");
            Console.ReadKey();
        }

        private static void SetCursorSize(int size)
        {
            Console.CursorSize = size;
            Console.Clear();
            Console.WriteLine($"Cursor size changed to: {size}");
        }

        private static void CustomCursorSize()
        {
            Console.Clear();
            Console.WriteLine("Enter custom cursor size: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            if (choice < 1 && choice > 100)
            {
                Console.WriteLine("Invalid range of input. Please try again.");
            }

            SetCursorSize(choice);
        }
    }
}