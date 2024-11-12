namespace FMBase.Hoomans;

public abstract class Hooman(int age, string name, float height)
{
    public int Age = age;
    public string Name = name;
    public float Height = height;
    public float FaithInClub = 50;
    public float Motivation = 50;



    public void CelebrateVictory()
    {
        Console.WriteLine("Victory!");
    }
}