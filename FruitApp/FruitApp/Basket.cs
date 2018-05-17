using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
     public class Basket : Fruit
    {
        private List<Fruit> ListOfFruits  ;

        public Basket()
        {
            ListOfFruits = new List<Fruit>(); 
        }

       

        public void Throw(Fruit fruit)
        {
            ListOfFruits.Remove(fruit);
        }

        public void DisplayFruits()
        {

            for (int i = 0; i < ListOfFruits.Count; i++)
            {
                Console.WriteLine(ListOfFruits[i].FruitName);
            }
           
        }

        public void AddFruit(Fruit fruits)
        {
            ListOfFruits.Add(fruits);
        }
    }
}
