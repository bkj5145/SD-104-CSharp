using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Hero
    {

       // public int maxHealth = 100;

        public int playerhealth;

        private int attackPower ;

        public int currentLevel ;
        public int currentEXP ;

        public bool playAlive = true;

        public Hero()
        {
            playerhealth = 5;
            currentEXP = 0;
            currentLevel = 1;
            attackPower = 2;
        }


        ////public void Attack(Monster monster)
        ////{
        ////    monster.monsterhealth -= this.attackPower;
        ////}


        public void AttackMonster(Monster monster)
        {
            monster.monsterhealth -= this.attackPower;
            Console.WriteLine("The Hero Attacks the Monster");
        }

        public bool IsHeroDead()
        {
            if (playerhealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void heroLevelUp()
        {
            int timesToLevel = this.currentEXP / 40;
            if (timesToLevel>0)
            {
                currentLevel += timesToLevel;
                attackPower += timesToLevel * 5;
                playerhealth += 3 * currentLevel;
                currentEXP -= timesToLevel * 40;
                Console.WriteLine("Hero level up! The current level is:" +currentLevel);
            }
            
        }
    }
}
