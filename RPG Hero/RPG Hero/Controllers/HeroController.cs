using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RPG_Hero.Models;
using TextBasedRPG;

namespace RPG_Hero.Controllers
{
    public class HeroController : Controller
    {
        private RPG_HeroContext db = new RPG_HeroContext();

        // GET: Hero
        public ActionResult Index()
        {
            RPG_HeroContext context = new RPG_HeroContext();
            List<Hero> heroes = context.getAllHeroes();
            return View(heroes);

        }

        // GET: Hero/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Health,currentLevel,CurrentExp,AttackPower")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Create(hero);
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Health,currentLevel,CurrentExp")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hero);
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
