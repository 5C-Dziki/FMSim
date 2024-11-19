namespace FMBase.Clubs;

public class Fanclub(string name, string description, string colors, int[] members, string loadout, string balance) : Club(name, description, colors, members)
{
    public string Loadout = loadout;
    public string Balance = balance;
}