using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriansTestMVC.Models
{
    public partial class Monster
    {
        public void LevelUp()
        {
            this.Lvl += 1;
            this.Health += 50;
        }

        [NotMapped]
        public Weapon HeroWeapon { get; set; }

    }
}