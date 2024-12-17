using FMBase.Hoomans;
using FMBase.ClubsTemp;
namespace FMBase.Clubs;

public class FootballClub(string name, string description, string colors, Player[] members, string jersey) : Club(name, description, colors)
{
    public string Jersey = jersey;
    public Player[] Members = members;

    public FootballClub LoadClub(bool OwnTeam)
    {
        if (OwnTeam)
        {
            return FootballClubsTemp.Generate(true);
        }
        else
        {
            return FootballClubsTemp.Generate(false);
        }
    }
}