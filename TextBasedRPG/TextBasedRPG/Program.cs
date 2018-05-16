using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {

            //Need to randomize the generation of the enemy with the Random class.
            // Probably should use a Switch statement to match on the new enemy that is generated, so assign each monster class to a number
            // and create a switch statement that matches on those numbers and create a new monster that the hero fights.

            int currentMonsterLevel = 1;
            Hero theHero = new Hero();
            Monster BigScaryMonster = new Goblin(currentMonsterLevel);

            while (theHero.IsHeroDead() == false)
            {
                theHero.AttackMonster(BigScaryMonster);
                if (BigScaryMonster.IsMonsterDead() == true)
                {
                    theHero.currentEXP += 20 ;
                    Console.WriteLine("The monster is Dead!!!!");
                    theHero.heroLevelUp();
                    currentMonsterLevel ++;
                     BigScaryMonster = new Goblin(currentMonsterLevel);
                    Console.WriteLine();
                }
             else
               {
                    BigScaryMonster.Attack(theHero);
                    Console.WriteLine("Monster attacks hero");
               }
                if (theHero.IsHeroDead() == false)
                {
                    Console.WriteLine("The Hero health is equal to: " +theHero.playerhealth);
                }
            }

            Console.WriteLine("The hero is dead!!!!");
            Console.ReadLine();

        }
    }
}
