using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TextBasedRPG;

namespace RPG_Hero.Models
{
    public class RPG_HeroContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public RPG_HeroContext() : base("name=RPG_HeroContext")
        {
        }

       

        public List<Hero> getAllHeroes()
        {
            string ConnectionString = @"Server=BRIANJOHNSON\SQLEXPRESS; Database= RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                List<Hero> heroes = new List<Hero>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from hero", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Hero hero = new Hero();
                    hero.Id = (int)dataReader["Id"];
                    hero.AttackPower = (int)dataReader["AttackPower"];
                    hero.Health = (int)dataReader["Health"];
                    hero.Lvl = (int)dataReader["Lvl"];
                    hero.CurrentExp = (int)dataReader["CurrentExp"];

                    heroes.Add(hero);
                }
                return heroes;
            }

        }

        public void Create(Hero hero)
        {
            string ConnectionString = @"Server=BRIANJOHNSON\SQLEXPRESS; Database= RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into hero values(@Health, @Lvl, @AttackPower, @CurrentExp", conn);

                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Health",
                    DbType = DbType.Int32,
                    Value = hero.Health,
                });


                // Need to map the rest of the Data Columns


                cmd.ExecuteNonQuery();
            }
        }
    }
}


