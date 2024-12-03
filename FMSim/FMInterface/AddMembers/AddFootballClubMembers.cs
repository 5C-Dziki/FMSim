using FMBase.Hoomans;

namespace FMInterface;

public class AddFootballClubMembers
{
    private string[] players;
    private string[] coaches;

    public void TeamManager()
    {
        players = new string[]
        {
            "Lionel Messi", "Cristiano Ronaldo", "Kylian Mbappé", "Neymar Jr.",
            "Kevin De Bruyne", "Robert Lewandowski", "Virgil van Dijk", "Sadio Mané",
            "Erling Haaland", "Harry Kane", "Luka Modrić", "Karim Benzema",
            "Mohamed Salah", "Gianluigi Donnarumma", "Raheem Sterling", "Son Heung-min",
            "Bruno Fernandes", "Joshua Kimmich", "Phil Foden", "Jadon Sancho",
            "Paul Pogba", "Thomas Müller"
        };
        
        coaches = new string[]
        {
            "Pep Guardiola", "Jürgen Klopp", "Zinedine Zidane", "Carlo Ancelotti", "Diego Simeone"
        };
    }

    public void Run()
    {
        Console.WriteLine("Choose three players to your team!");
        string[] chosenPlayers = ChoosePlayers();

        Console.WriteLine("\nYou need a coach too!");
        string chosenCoach = ChooseCoach();

        DisplaySummary(chosenPlayers, chosenCoach);
    }

    private string[] ChoosePlayers()
    {
        string[] chosenPlayers = new string[3];
        int count = 0;

        while (count < 3)
        {
            DisplayArray(players);
            Console.Write("\nEnter the index of the player (1-22): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= players.Length)
            {
                string player = players[index - 1];
                if (Array.IndexOf(chosenPlayers, player) == -1)
                {
                    chosenPlayers[count] = player;
                    count++;
                    Console.WriteLine($"Added: {player}");
                }
                else
                {
                    Console.WriteLine("Player already chosen. Choose a different player.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        return chosenPlayers;
    }

    private string ChooseCoach()
    {
        string chosenCoach = "";

        while (string.IsNullOrEmpty(chosenCoach))
        {
            DisplayArray(coaches);
            Console.Write("\nEnter the index of the coach (1-5): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= coaches.Length)
            {
                chosenCoach = coaches[index - 1];
                Console.WriteLine($"Coach selected: {chosenCoach}");
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        return chosenCoach;
    }

    private void DisplayArray(string[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }

    private void DisplaySummary(string[] chosenPlayers, string chosenCoach)
    {
        Console.WriteLine("\nYour team:");
        foreach (string player in chosenPlayers)
        {
            Console.WriteLine($"- {player}");
        }

        Console.WriteLine($"Coach: {chosenCoach}");
        Console.WriteLine("\nGood luck and have fun!");
    }
}