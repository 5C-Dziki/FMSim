namespace FMInterface.Tutorial
{
    public class Tutorial
    {
        private readonly List<(string Header, string[] Content)> _tutorialSteps;

        public Tutorial()
        {
      
            _tutorialSteps = new List<(string Header, string[] Content)>
            {
                (
                    "Welcome to FMSIM Tutorial!",
                    new[]
                    {
                        "This will guide you through the game mechanics.",
                        
                    }
                ),
                (
                    "Starting a New Game",
                    new[]
                    {
                        "In this tutorial, you will learn how to start a new game and modify settings.",
                        "1. Go to 'New Game' from the main menu.",
                        "2. Choose 'Football Club' or 'User Club' to create your own team.",
                        
                    }
                ),
                (
                    "Settings Overview",
                    new[]
                    {
                        "This section will explain all existing settings in FMSIM.",
                        "1. All settings can be found in the 'Settings' tab, accessed from the main menu.",
                        "2. Difficulty: Change the level of difficulty of the opponent.",
                        "3. Color Scheme: Change the color scheme or choose custom colors.",
                        "4. Cursor Visibility: Show or hide the cursor.",
                        "5. Cursor Size: Change the cursor size (works only when the cursor is visible).",
                        
                    }
                ),
                (
                    "Start Game: Creating Your Club",
                    new[]
                    {
                        "In the 'Start Game' tab, press 'New Game' to start a new game.",
                        "You will have two options: Football Club and User Club.",
                        "1. Choose your club type (Football Club or User Club).",
                        "2. Fill out the form to create YOUR OWN CLUB!",
                        "3. Play and enjoy the game!",
                        
                    }
                ),
                (
                    "Tutorial Completed!",
                    new[]
                    {
                        "Thank you for using FMSIM!",
                        "Press any key to exit."
                    }
                )
            };
        }


        private void DisplayTutorialStep(string header, string[] content)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine(new string('-', 40));

            foreach (var line in content)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("\nPress any key to continue or 'Q' to exit.");
        }


        public void RunTutorial()
        {
            bool tutorialOn = true;

            foreach (var step in _tutorialSteps)
            {
                DisplayTutorialStep(step.Header, step.Content);

 
                if (Console.ReadKey(true).Key == ConsoleKey.Q) break;
            }

            Console.Clear();
            Console.WriteLine("Thank you for completing the tutorial!");
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
