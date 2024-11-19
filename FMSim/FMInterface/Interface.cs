using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace FMInterface
{
    public class Interface 
    {

    }

    public class Menu : Interface
    {
 

        List<Option> MenuOptions = new List<Option>();
        public Menu(string[] options, int len)
        {
           
            for (int i = 0; i < len; i++)
            {
               
                MenuOptions[i] = options[i]; 
            }
        }
        public int DisplayMenu()
        {
          
            for (int i = 0; i < MenuOptions.Count; i++) 
            {
                Console.WriteLine(i + ". " + MenuOptions[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter next action: ");
            int UserInput;
            bool Success = int.TryParse(Console.ReadLine(),out UserInput);
            if (!Success) 
            {
                Console.WriteLine("Wrong input");
            }
            return UserInput;
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to FMSIM!");
            Console.WriteLine("");
        }

        public void Clear()
        {
            Console.Clear();
        }

    }
    public class MenuSwitchHandler
    {
        public int Input;
        public int CurrentMenu;
        public string[,] ListOfMenus;
        public string[] CurrentMenuContent;
      
        public MenuSwitchHandler(int input, int currentMenu, string[] currentmenucontent, string[,] listOfMenus)
        {
            this.CurrentMenu = currentMenu;
            if (input < 0 || input >= CurrentMenuContent.Length)
            {
                throw new ArgumentOutOfRangeException("input out of range");
            }
            else
            {
                this.Input = input;
            }
            this.ListOfMenus = listOfMenus;
            this.CurrentMenuContent = currentmenucontent;
            
        }
        public void SwitchToNewMenu()
        {
            string newMenu;
            switch (this.Input)
            {
                case 0:
                    newMenu = CurrentMenuContent[0];
                    break;
                case 1:
                    newMenu = CurrentMenuContent[1];
                    break;
                case 2:
                    newMenu = CurrentMenuContent[2];
                    break;
                case 3:
                    newMenu = CurrentMenuContent[3];
                    break;
                case 4:
                    newMenu = CurrentMenuContent[4];
                    break;
                default:
                    newMenu = "No new menu";
                    break;
            }
            Menu Menu = new Menu(ListOfMenus[CurrentMenu, newMenu], ListOfMenus[CurrentMenu, newMenu].Length);

        }
    
    }
    public class Option(string value)
    {
        string Value = value;

        public static implicit operator Option(string v)
        {
            throw new NotImplementedException();
        }
    }

 
    internal class Run
    {
        
        static void Main(string[] args)
        {
            string[] basicInterface = new string[4] { "New game", "Load game", "Settings", "Exit" };
            string[] settingsInterface = new string[3] { "Diffuculty", "Color scheme", "Exit" };
            //Menu i1 = new Menu(basicInterface, basicInterface.Length);
            //i1.WelcomeMessage();
            //i1.DisplayMenu();   
            bool isRunning = true;
            while (isRunning)
            {

            }

        }
    }

    
}
