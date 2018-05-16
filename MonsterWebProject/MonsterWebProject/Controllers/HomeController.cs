using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextBasedRPG;

namespace MonsterWebProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            Random r = new Random();

            int randomNum;

            List<Monster> monster = new List<Monster>();
            for (int i = 0; i < 10; i++)
            {
                randomNum = r.Next(1, 8);
                switch (randomNum)
                {
                    case 1:
                        monster.Add(new Goblin(1));
                        break;
                    case 2:
                        monster.Add(new HoodedGoblin(1));
                        break;
                    case 3:
                        monster.Add(new Skeleton(1));
                        break;
                    case 4:
                        monster.Add(new SpearGoblin(1));
                        break;
                    case 5:
                        monster.Add(new Zombie(1));
                        break;
                    case 6:
                        monster.Add(new ZombieArcher(1));
                        break;

                    default:
                        monster.Add(new Goblin(1));
                        break;
                }

            }

            return View(monster);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}