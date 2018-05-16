using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    public class Hero
    {

        // public int maxHealth = 100;

        public int Id { get; set; }

        public int Health { get; set; }

        public int AttackPower { get; set; }

        public int Lvl { get; set; }
        public int CurrentExp { get; set; }
        public bool playAlive = true;

        public Hero()
        {
            Health = 5;
            CurrentExp = 0;
            Lvl = 1;
            AttackPower = 2;
        }


        ////public void Attack(Monster monster)
        ////{
        ////    monster.monsterhealth -= this.attackPower;
        ////}


        public void AttackMonster(Monster monster)
        {
            monster.monsterhealth -= this.AttackPower;
            Console.WriteLine("The Hero Attacks the Monster");
        }

        public bool IsHeroDead()
        {
            if (Health <= 0)
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
            int timesToLevel = this.CurrentExp / 40;
            if (timesToLevel>0)
            {
                Lvl += timesToLevel;
                AttackPower += timesToLevel * 5;
                Health += 3 * Lvl;
                CurrentExp -= timesToLevel * 40;
                Console.WriteLine("Hero level up! The current level is:" +Lvl);
            }
            
        }
    }
}
