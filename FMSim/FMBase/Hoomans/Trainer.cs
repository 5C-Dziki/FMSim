namespace FMBase.Hoomans;

public class Trainer(int age, string name, float height, int experience) : Hooman(age, name, height)
{
    public int Experience = experience;
    public string[] Achievements = new string[100];
    public string[] Clubs = new string[20];
    public int[] Formation;
    public bool HasFansSupport = false;
    public bool HasClubSupport = false;
    static Random _random = new Random();
    public int Charisma = _random.Next(1,99);

    public void Reprimand()
    {
        Random random = new Random();
        if (this.Charisma < random.Next(1, 100))
        {
            Console.WriteLine("Reprimand unsuccessful, morale went down!");
        }
        else
        {
            Console.WriteLine("Reprimand successful, morale went up!");
        }
    }

    public void FormationChange()
    {
        Console.WriteLine("Input formation length");
        Console.WriteLine("Input formation width (start with defense, eg. 4-3-3)");
        for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
        {
            this.Formation[i] = Convert.ToInt32(Console.ReadLine());
        }

        int x = 0;
        for (int i = 0; i < this.Formation.Length; i++)
        {
            x += this.Formation[i];
        }

        if (x != 10)
        {
            Console.WriteLine("Wrong formation, try again!");
            FormationChange();
        }
    }
}