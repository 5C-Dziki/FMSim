﻿using System;
using System.Collections.Generic;
using FMBase.Clubs;
using FMInterface.CreateClub;
using FMInterface.Settings;
using System.Threading;

namespace FMInterface
{

    public class Menu
    {
        public List<string> MenuOptions { get; private set; }

        public Menu(string[] options)
        {
            MenuOptions = new List<string>(options);
        }

        public int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select an option:");

            for (int i = 0; i < MenuOptions.Count; i++)
            {
                Console.WriteLine($"{i+1}. {MenuOptions[i]}");
            }

            Console.WriteLine();
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 0 && (userInput -1) < MenuOptions.Count)
            {
                return userInput;
            }

            Console.WriteLine("Invalid input. Press any key to try again.");
            Console.ReadKey();
            return -1;
        }

        public void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome to FMSIM!");
            Console.WriteLine("=================\n");
        }
    }

    public class MenuSwitchHandler
    {
        private readonly Dictionary<string, string[]> _menus;
        private readonly Stack<string> _menuHistory;
        public int Menu;

        public string CurrentMenu { get; private set; }

        public MenuSwitchHandler(Dictionary<string, string[]> menus, string startMenu, int menu)
        {
            _menus = menus;
            _menuHistory = new Stack<string>();
            CurrentMenu = startMenu;
            Menu = menu;
        }

        public Menu GetCurrentMenu()
        {
            return new Menu(_menus[CurrentMenu]);
        }

        public void HandleMenuSelection(int input)
        {
            input -= 1;
            if (input == _menus[CurrentMenu].Length - 1) 
            {
                if (_menuHistory.Count > 0)
                {
                    CurrentMenu = _menuHistory.Pop(); 
                }
                else
                {
                    CurrentMenu = null; 
                }
            }
            else
            {
                string nextMenu = _menus[CurrentMenu][input];
                if (CurrentMenu == "Start Game" && nextMenu == "Fan Club")
                {
                    Console.Clear();
                     UserFanClub mainClub = FanClubManager.CreateClub();
                     Menu = 2;
                    Thread.Sleep(3000);
                }

                if (CurrentMenu == "Start Game" && nextMenu == "Football Club")
                {
                    Console.Clear();
                    Console.WriteLine("Feature not yet working");
                    Thread.Sleep(3000);
                    return;
                }
                
                if (CurrentMenu == "Settings" && nextMenu == "Color Scheme")
                {
                    FMInterface.Settings.ColorSettings.ChangeColorScheme();
                    return;
                }

                if (CurrentMenu == "Settings" && nextMenu == "Cursor Visibility")
                {
                    CursorSettings cursorSettings = new CursorSettings();
                    cursorSettings.ToggleCursorVisibility();

                    Console.Clear();
                    Console.WriteLine($"Cursor is now {(cursorSettings.IsCursorVisible ? "visible" : "hidden")}");
                    Console.ReadKey();

                }


                if(CurrentMenu == "Settings" && nextMenu == "Cursor Size")
                {
                    FMInterface.Settings.CursorSizeSettings.ChangeCursorSize();
                    return;
                }


                if (_menus.ContainsKey(nextMenu))
                {
                    _menuHistory.Push(CurrentMenu);
                    CurrentMenu = nextMenu;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No further menus. Press any key to return.");
                    Console.ReadKey();
                }
            }
        }
    }

    internal class Run
    {
        static void Main(string[] args)
        {
            int MenuNum = 0;
            if (MenuNum == 0)
            {
                var menus = new Dictionary<string, string[]>
            {
                { "MainMenu", new[] { "New Game", "Load Game", "Settings", "Exit" } },
                { "Settings", new[] { "Difficulty", "Color Scheme", "Cursor Visibility", "Cursor Size", "Advanced Settings", "Exit" } },
                { "New Game", new[] { "Start Game", "Tutorial", "How to play?", "Exit"} },
                { "Load Game", new[] { "Load Game from save", "Load game from file", "How to load a game?", "Exit"} },
                { "Advanced Settings", new[] { "Key Binds", "Game Info", "Exit" } },
                { "Start Game" ,new[] {"Football Club", "Fan Club", "Exit"}}
            };


                var menuSwitchHandler = new MenuSwitchHandler(menus, "MainMenu", MenuNum);


                var welcomeMenu = menuSwitchHandler.GetCurrentMenu();
                welcomeMenu.WelcomeMessage();

                bool isRunning = true;
                while (isRunning)
                {
                    var currentMenu = menuSwitchHandler.GetCurrentMenu();
                    int selection = currentMenu.DisplayMenu();

                    if (selection == -1) continue;

                    menuSwitchHandler.HandleMenuSelection(selection);

                    if (menuSwitchHandler.CurrentMenu == null)
                    {
                        isRunning = false;
                    }

                    if (menuSwitchHandler.Menu == 2)
                    {
                        isRunning = false;
                    }
                }

                Console.WriteLine("Thank you for using FMSIM! Goodbye.");
            }
        }
    }
}
