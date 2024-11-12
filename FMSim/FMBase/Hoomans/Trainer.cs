namespace FMBase.Hoomans;

public class Trainer(int age, string name, float height, float faithInClub, float motivation, int experience) : Hooman(age, name, height, faithInClub, motivation)
{
    public int Experience = experience;
    public string[] Achievements = new string[100];
    public string[] Clubs = new string[20];
    public int[] Formation;
    public bool HasFansSupport = false;
    public bool HasClubSupport = false;
    static Random _random = new Random();
    public int Charisma = _random.Next(1,99);

    public void Reprimend()
    {
        Random random = new Random();
        if (this.Charisma < random.Next(1, 100))
        {
            Console.WriteLine("reprimend unsuccessful, morale went down!");
        }
        else
        {
            Console.WriteLine("Reprimend successful, morale went up!");
        }
    }

    public void FormationChange()
    {
        Console.WriteLine("podaj dlugosc formacji");
        for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
        {
            Console.WriteLine("podaj liczbe z formacji");
            this.Formation[i] = Convert.ToInt32(Console.ReadLine());
        }

        int x = 0;
        for (int i = 0; i < this.Formation.Length; i++)
        {
            x += this.Formation[i];
        }

        if (x != 10)
        {
            Console.WriteLine("Zla formacja");
        }
    }
}