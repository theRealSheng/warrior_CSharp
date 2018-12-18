using System;
using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Joe", Faction.Badguy);

            while(true)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}
