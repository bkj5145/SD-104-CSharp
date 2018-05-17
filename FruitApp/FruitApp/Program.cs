using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket myBasket = new Basket();

            Banana mybanana = new Banana();
            Mango myMango = new Mango();
            Apple myApple = new Apple();


            myBasket.AddFruit(mybanana);
            myBasket.AddFruit(myMango);
            myBasket.AddFruit(myApple);

            myBasket.Throw(myApple);

            myBasket.DisplayFruits();

            Console.ReadLine();
            
        }
    }
}
