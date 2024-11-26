using System;
using System.Reflection.Metadata;
using System.Text;
using FMBase.Clubs;
using FMBase.Hoomans;
using System.Collections.Generic;
namespace FMInterface.Actions;

public class FanFight
{
    public  void fan_fighting(Fanclub selfFanclub, Fanclub enemyFanclub)
    {
        Console.WriteLine($"fight begins: {selfFanclub.Name} VS {enemyFanclub.Name}");
        var membersLength = selfFanclub.Members.Length;
        Random randMember = new Random();
        var fighter = selfFanclub.Members[randMember.Next(0, membersLength)];
        fighter.Fight();
    }
}