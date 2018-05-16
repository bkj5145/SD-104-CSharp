using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    abstract class Monster
    {
        

        public int monsterhealth;

        public int attackPower;

        public int monsterLevel;
        public int range;

        public bool monsterAlive = true;


        //Monster Constructor
       


        public bool IsMonsterDead()
        {
            if (monsterhealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract void Attack(Hero hero);

    }
}
