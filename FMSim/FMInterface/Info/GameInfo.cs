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
            "Project Manager: Michal Krol",
            "Head of Programmers Team: Maksymilian Fikus",
            "Programmer: Kamil Checinski",
            "Programmer: Bartlomiej Luc",
            "Programmer Assistant: Jan Grzeskowiak"
        };
        
        foreach (var line in infoList)
        {
            Console.WriteLine(line);
            Thread.Sleep(2000);
        }
    }
}