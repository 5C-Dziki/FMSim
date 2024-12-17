using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInterface.Tutorial
{
    public static class Turorial
    {
        public static void TutorialWelcome()
        {
            Console.WriteLine("Welcome to FMSIM tutorial");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }
        public static void TutorialExit()
        {
           Console.WriteLine("'q' key exits tabs the the previous ones");
        }

        public static void TutorialClear()
        {
            Console.Clear();
        }
        public static void TutorialSettings()
        {
            Console.WriteLine("This sections will explain all existing settings in FMSIM");
            Console.WriteLine("\n");
            Thread.Sleep(3000);
            Console.WriteLine("All settings can be find in Settings tab, accesses from the main menu");
            Console.WriteLine("\n");
            Thread.Sleep(3000);
            Console.WriteLine("Difficulty settings tab allows for a change in the level of difficulty of the opponent");
            Console.WriteLine("\n");
            Thread.Sleep(3000);
            Console.WriteLine("Color settings tab allows for a change in color scheme of the console. It also let user choose custom colors");
            Console.WriteLine("\n");
            Thread.Sleep(3000);
            Console.WriteLine("Cursor visibility tab allows user to hide or show cursor while using our app");
            Console.WriteLine("\n");
            Thread.Sleep(3000);
            Console.WriteLine("Cursor size tab allows for a change in the size of the cursor while using our app. It only works when cursor is visible");
            Console.WriteLine("\n");
            Thread.Sleep(3000);
        }
    }
}
