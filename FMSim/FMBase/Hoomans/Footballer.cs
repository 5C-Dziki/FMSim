namespace FMBase.Hoomans;

public class Footballer(int age, string name, float height, float faithInClub, float motivation, int physical, int pace, int shooting, int defending, int passing, int dribbling, int pos) : Hooman(age, name, height, faithInClub, motivation)
{
    public int Physical = physical;
    public int Pace = pace;
    public int Shooting = shooting;
    public int Defending = defending;
    public int Passing = passing;
    public int Dribbling = dribbling;
    public string[] Achievements = new string[100];
    public string[] Clubs = new string[20];
    public bool IsCapitain = false;
    public int Pos = pos;

    public void Pass()
    {
        Random random = new Random();
        if (this.Passing < random.Next(1, 100))
        {
            Console.WriteLine("Pass unsuccessful!");
        }
        else
        {
            Console.WriteLine("Pass successful!");
        }
    }

    public void Defend()
    {
        Random random = new Random();
        if (this.Defending < random.Next(1, 100))
        {
            Console.WriteLine("You Fouled!");
        }
        else
        {
            Console.WriteLine("Clean tackle!");
        }
    }

    public void Shoot()
    {
        Random random = new Random();
        if (this.Shooting < random.Next(1, 100))
        {
            Console.WriteLine("You Missed!");
        }
        else
        {
            Console.WriteLine("Goal!");
        }
    }

    public void Dribble()
    {
        Random random = new Random();
        if (this.Dribbling < random.Next(1, 100))
        {
            Console.WriteLine("You lost the ball!");
        }
        else
        {
            Console.WriteLine("Succesful dribble!");
        }
    }
}