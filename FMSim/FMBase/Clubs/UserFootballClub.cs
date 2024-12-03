using FMBase.Hoomans;

namespace FMBase.Clubs
{
    public class UserFootballClub(string name, string description, string colors, Player[] players)
        : Club(name, description, colors)
        {
            int _playerCount = players.Length;
            public void AddPlayer(Player player)
            {
                for (int i = 0; i < _playerCount; i++)
                {
                    if (players[i] == null)
                    {
                        players[i] = player;
                    }
                }
            }

            public void DisplayClubInfo()
            {
                Console.WriteLine($"Club Name: {Name}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Colors: {Colors}");
                Console.WriteLine($"Players: {_playerCount}");
            }
        }
    }
