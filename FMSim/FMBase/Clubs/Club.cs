namespace FMBase.Clubs;

public abstract class Club(string name, string description, string colors, int[] members)
{
    public string Name = name;
    public string Description = description;
    public string Colors = colors;
    public int[] Members = members;
}

