namespace FMBase;

public abstract class Hooman(int age, string name, float height, float faithInClub, float motivation)
{
    public int Age = age;
    public string Name = name;
    public float Height = height;
    public float FaithInClub = faithInClub;
    public float Motivation = motivation;



    public void CelebrateVictory()
    {
        Console.WriteLine("Victory!");
    }
}