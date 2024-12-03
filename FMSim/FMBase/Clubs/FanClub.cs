using FMBase.Hoomans;
namespace FMBase.Clubs;



public class FanClub(string name, string description, string colors, Fan[] members) : Club(name, description, colors)
{
    public Fan[] Members = members;
}