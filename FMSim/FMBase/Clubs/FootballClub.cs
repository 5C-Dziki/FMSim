namespace FMBase.Clubs;

public class FootballClub(string name, string description, string colors, int[] members, string jersey) : Club(name, description, colors, members)
{
    public string Jersey = jersey;
}