using FMBase.Clubs;

namespace FMInterface.CreateClub
{
    public class UserClub : Club
    {
        public UserClub(string name, string description, string colors)
            : base(name, description, colors, new int[0])
        {
        }
        public void AddMember(int memberId)
        {
            Members = Members.Concat(new[] { memberId }).ToArray();
        }
        
        public void DisplayClubInfo()
        {
            Console.WriteLine($"Club Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Colors: {Colors}");
            Console.WriteLine($"Members Count: {Members.Length}");
        }
    }
}