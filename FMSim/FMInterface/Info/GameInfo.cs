using FMBase;

namespace FMInterface.Info;

public class GameInfo
{
    public static void DisplayGameInfo()
    {
        List<string> infoList = new List<string>
        {
            "FMSim",
            "Copyright © 2024",
            "Team:",
            "Project Manager: Michał Król",
            "Head of Programmers Team: Maksymilian Fikus",
            "Programmer: Kamil Chęciński",
            "Programmer: Bartłomiej Łuć",
            "Programmer Assistant: Jan Grześkowiak"
        };
        
        foreach (var line in infoList)
        {
            Console.WriteLine(line);
            Thread.Sleep(2000);
        }
    }
}