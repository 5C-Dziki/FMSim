using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace FMInterface
{

    public class Interface
    {
        public List<string> MenuOptions = new List<string>();

        public Interface(string[] options, int len)
        {

            for (int i = 0; i < len; i++)
            {
                MenuOptions.Add(options[i]);
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
                Console.WriteLine("Wrong inout");
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
    internal class Run
    {
        
        static void Main(string[] args)
        {
            string[] o = new string[4] { "New game", "Load game", "Settings", "Exit" };
            Interface BasicInterface = new Interface(o, o.Length);
            BasicInterface.WelcomeMessage();
            BasicInterface.DisplayMenu();   
        }
    }

    
}
