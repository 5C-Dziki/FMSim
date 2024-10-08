namespace ConsoleApp1;

class Program
{
    public class Hooman
    {
        public int age;
        public string name;
        public float height;
        public float faithInClub;
        public float motivation;

        public void celebrateVictory()
        {
            Console.WriteLine("Victory!");
        }
    }
    public class Footballer : Hooman
    {
        public int physical;
        public int pace;
        public int shooting;
        public int defending;
        public int passing;
        public int dribbling;
        public string[] achievements;
        public string[] clubs;
        public bool isCapitain;
        public int pos;

        public void pass()
        {
            Random random = new Random();
            if (this.passing < random.Next(1, 100))
            {
                Console.WriteLine("Pass unsuccessful!");
            }
            else
            {
                Console.WriteLine("Pass successful!");
            }
        }

        public void defend()
        {
            Random random = new Random();
            if (this.defending < random.Next(1, 100))
            {
                Console.WriteLine("You Fouled!");
            }
            else
            {
                Console.WriteLine("Clean tackle!");
            }
        }

        public void shoot()
        {
            Random random = new Random();
            if (this.shooting < random.Next(1, 100))
            {
                Console.WriteLine("You Missed!");
            }
            else
            {
                Console.WriteLine("Goal!");
            }
        }

        public void dribble()
        {
            Random random = new Random();
            if (this.dribbling < random.Next(1, 100))
            {
                Console.WriteLine("You lost the ball!");
            }
            else
            {
                Console.WriteLine("Succesful dribble!");
            }
        }
    }
    public class Trainer : Hooman
    {
        public int experience;
        public string[] achievements;
        public string[] clubs;
        public int[] formation;
        public bool hasFansSupport;
        public bool hasClubSupport;
        public int charisma;

        public void reprimend()
        {
            Random random = new Random();
            if (this.charisma < random.Next(1, 100))
            {
                Console.WriteLine("reprimend unsuccessful, morale went down!");
            }
            else
            {
                Console.WriteLine("Reprimend successful, morale went up!");
            }
        }

        public void formationChange()
        {
            Console.WriteLine("podaj dlugosc formacji");
            for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
            {
                Console.WriteLine("podaj liczbe z formacji");
                this.formation[i] = Convert.ToInt32(Console.ReadLine());
            }

            int x = 0;
            for (int i = 0; i < this.formation[].Length; i++)
            {
                x += this.formation[i];
            }

            if (x!=10)
            {
                Console.WriteLine("Zla formacja");
            }
        }
    }
    
    public class Fan : Hooman
    {
        public bool isAngry;
        public float frustration;
        public bool isFlagHolder;
        public int power;
        public int flagsWon;
        public int flagsLost;
        public string[] kosy;
        public string[] zgody;

        public void ustawka()
        {
            Random random = new Random();
            if (this.power < random.Next(1, 100))
            {
                Console.WriteLine("You lost one flag!");
                this.flagsLost++;
            }
            else
            {
                Console.WriteLine("You Win and gain a flag!");
                this.flagsWon++;
            }
        }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Nigger");
    }
}