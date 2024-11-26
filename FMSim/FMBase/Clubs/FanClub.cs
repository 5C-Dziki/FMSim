using FMBase.Hoomans;
namespace FMBase.Clubs;



public class FanClub(string name, string description, string colors, Fan[] members, string loadout, string balance) : Club(name, description, colors)
{
    public string Loadout = loadout;
    public Fan[] Members = members;
}