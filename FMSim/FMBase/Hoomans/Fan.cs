using System.Xml.Linq;

namespace FMBase;

public class Fan(int age, string name, float height, float faithInClub, float motivation, bool isAngry, float frustration, bool isFlagHolder, int power) : Hooman(age, name, height, faithInClub, motivation)
{
    static readonly Random Xd = new Random();
    public bool IsAngry = isAngry;
    public float Frustration = frustration;
    public bool IsFlagHolder = isFlagHolder;
    private int _power = Xd.Next(1,100);
    public int FlagsWon = 0;
    public int FlagsLost = 0;
    public string[] Beefs= new string[100];
    public string[] Agreements = new string[100];

    
    
    public void Ustawka()
    {
        Random random = new Random();
        if (this._power < random.Next(1, 100))
        {
            Console.WriteLine("You lost one flag!");
            this.FlagsLost++;
        }
        else
        {
            Console.WriteLine("You Win and gain a flag!");
            this.FlagsWon++;
        }
    }
}