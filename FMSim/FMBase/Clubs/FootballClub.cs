namespace FMBase.Clubs;

public class FootballClub(string name, string description, string colors, int[] members, string formation, string jersey) : Club(name, description, colors, members)
{
    public string Formation = formation;
    public string Jersey = jersey;
}