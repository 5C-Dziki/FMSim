using System;
using System.Reflection.Metadata;
using System.Text;
using FMBase.Clubs;
using FMBase.Hoomans;
using System.Collections.Generic;
namespace FMInterface.Actions;

public class FanFight
{
    public  void fan_fighting(FanClub selfFanClub, FanClub enemyFanClub)
    {
        Console.WriteLine($"fight begins: {selfFanClub.Name} VS {enemyFanClub.Name}");
        var membersLength = selfFanClub.Members.Length;
        Random randMember = new Random();
        var fighter = selfFanClub.Members[randMember.Next(0, membersLength)];
        fighter.Fight();
    }
}