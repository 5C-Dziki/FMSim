namespace FMBase.Hoomans;

public class Player(int age, string name, float height, int physical, int run, int shooting, int defending, int passing, int dribbling, string pos) : Hooman(age, name, height)
{
    public int Physical = physical;
    public int Run = run;
    public int Shooting = shooting;
    public int Defending = defending;
    public int Passing = passing;
    public int Dribbling = dribbling;
    public string[] Achievements = new string[100];
    public string[] Clubs = new string[20];
    public bool IsCapitain = false;
    public string Pos = pos;

}