namespace FMBase.Clubs
{
    public class UserFootballClub : Club
    {
        public UserFootballClub(string name, string description, string colors)
            : base(name, description, colors)
        {
        }
        public void AddMember(int memberId)
        {
            //string[] Members = Members.Concat(new[] { memberId }).ToArray();
        }

        public void DisplayClubInfo()
        {
            Console.WriteLine($"Club Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Colors: {Colors}");
            //Console.WriteLine($"Members Count: {Members.Length}");
        }
    }
}