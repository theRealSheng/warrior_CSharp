using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;

        private int damage;

        public int Damange 
        { 
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
				case Faction.GoodGuy:
					damage = GOOD_GUY_DAMAGE;
					break;
				case Faction.Badguy:
					damage = BAD_GUY_DAMAGE;
					break;
				default:
					break;
            }
        }
    }
}