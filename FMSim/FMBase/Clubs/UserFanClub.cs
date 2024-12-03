using FMBase.Clubs;
using FMBase.Hoomans;

namespace FMBase.Clubs;

public class UserFanClub (string name, string description, string colors, Fan[] members) : FanClub (name, description, colors, members)
{

    public void AddFan()
    {
        Console.WriteLine("Name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Height: ");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("is Flag Holder?(y/n): ");
        string? isFlagHolder = Console.ReadLine();
        bool flag = isFlagHolder?.ToLower() == "y";

        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] == null)
            {
                members[i] = new Fan(age, name, height, false, 0, flag);
                break;
            }
        }
    }
}