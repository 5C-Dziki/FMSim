using FMBase.Hoomans;
namespace FMBase.Clubs;

public abstract class Club(string name, string description, string colors)
{
    public string Name = name;
    public string Description = description;
    public string Colors = colors;
}

