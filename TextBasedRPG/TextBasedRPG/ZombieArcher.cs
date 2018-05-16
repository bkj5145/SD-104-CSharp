using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class ZombieArcher : Monster
    {
        public ZombieArcher()
        {

        }

        

        //Monster Constructor
        public ZombieArcher(int level)
        {

            range = 1;

            if (level == 1)
            {
                attackPower = 1;
            }
            else
            {
                attackPower = 2* level;
            }
            monsterhealth = 2*level;
            this.monsterLevel = level;
        }

        public override void Attack(Hero hero)
        {
          
        }
    }
}
