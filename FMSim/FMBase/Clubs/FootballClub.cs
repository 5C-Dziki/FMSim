using FMBase.Hoomans;

namespace FMBase.Clubs;

public class FootballClub(string name, string description, string colors, Player[] members, string jersey) : Club(name, description, colors)
{
    public string Jersey = jersey;
    public Player[] Members = members;
}