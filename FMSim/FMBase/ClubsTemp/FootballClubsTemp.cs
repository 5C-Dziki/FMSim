using FMBase.Clubs;
using FMBase.Hoomans;

namespace FMBase.ClubsTemp;

public class FootballClubsTemp
{
    public static FootballClub Generate(bool ownTeam)
    {
        FootballClub fc1 = new FootballClub("Club1", "Gud", "#331234", new Player[11], "#313141");
        fc1.Members[0] = new Player(20, "Afimico Pululu", 191, 68, 92, 68, 26, 57, 71, "Forward");
        fc1.Members[1] = new Player(25,"Kylian Mbappe",182,82,99,93,39,84,95,"Forward");
        fc1.Members[2] = new Player(17,"Lamine Yamal",180,80,93,94,40,93,95, "Forward");
        fc1.Members[3] = new Player(28, "Rodri", 191, 85, 66, 80, 87, 86, 84, "Midfielder");
        fc1.Members[4] = new Player(62,"Ruud Gullit",191,87,85,88,80,88,86, "Midfielder");
        fc1.Members[5] = new Player(40, "Wesley Sneijder", 171, 75,81,84,53,90,86, "Midfielder");
        fc1.Members[6] = new Player(29, "Nathan Ake",180, 86, 82, 57, 89, 81, 82, "Defender");
        fc1.Members[7] = new Player(25,"Tuta",185,90,83,62,90,77,84, "Defender");
        fc1.Members[8] = new Player(48,"Lucio",188,89,82,72,91,74,77, "Defender");
        fc1.Members[9] = new Player(26,"Trent Alexander-Arnold",180,80,82,75,87,91,86, "Defender");
        fc1.Members[10] = new Player(32, "Marc-Andre Ter Stegen", 187, 86, 47, 85, 86, 89, 91, "Goalkeeper");
        
       FootballClub fc2 = new FootballClub("Club2", "Gud", "#331234", new Player[11], "#313141");
       fc2.Members[0] = new Player(36,"Robert Lewandowski",185,87,85,90,48,85,88, "Forward");
       fc2.Members[1] = new Player(30,"Raheem Sterling", 172,75,90,85,47,80,88, "Forward");
       fc2.Members[2] = new Player(35,"Gareth Bale",186,79,95,89,65,84,89, "Forward");
       fc2.Members[3] = new Player(21,"Maurits Kjaergaard",192,77,75,71,64,72,73, "Midfielder");
       fc2.Members[4] = new Player(26,"Matheus Nunes",183,76,83,71,73,74,81, "Midfielder");
       fc2.Members[5] = new Player(26,"Federico Valverde",182,87,91,86,84,89,89,"Midfielder");
       fc2.Members[6] = new Player(51,"Roberto Carlos",168,86,91,83,85,83,80, "Defender");
       fc2.Members[7] = new Player(25,"Edmond Tapsoba", 192,79,75,54,85,68,70, "Defender");
       fc2.Members[8] = new Player(33,"Virgil Van Dijk",193,90,83,64,93,75,75, "Defender");
       fc2.Members[9] = new Player(34,"Kyle Walker",183,81,89,64,79,77,78, "Defender");
       fc2.Members[10] = new Player(46,"Gianluigi Buffon",192,89,51,86,94,78,93,"Goalkeeper");

       if (ownTeam)
       {
           return fc1;
       }
       else
       {
           return fc2;
       }
    }
}

