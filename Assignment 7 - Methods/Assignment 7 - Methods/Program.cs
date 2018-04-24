using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
                int max = 5;

            bool playAgain = true;
            int correctNumber = RandomNumber(min, max);
            while (playAgain ==true)
            {
                //write logic that will check if you got the number or if your too high or too low
                

                Console.WriteLine("Please enter a number between " + min +  " and " + max + ".");
                int userGuess = InputNumber();

               

                if (userGuess == correctNumber)
                {
                    Console.WriteLine("You entered the correct number!");


                    string input;

                    Console.WriteLine("Would you like to try again Y or N");
                     input = Console.ReadLine().ToUpper();
                     if (input.ToUpper() == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }

                    while (input != "Y" && input != "N")
                    {
                        Console.WriteLine("Please enter Y for Yes or N for No!");

                        Console.WriteLine("Would you like to try again Y or N");
                        input = Console.ReadLine().ToUpper();
                    }


                   
                }
                else 
                {
                    
                    if (userGuess < correctNumber)
                    {
                        Console.WriteLine("The number you entered is less than the Correct Number!");


                    }
                    if (userGuess> correctNumber)
                    {
                        Console.WriteLine("The number you entered is greater than the Correct Number!");
                    }
                }


                
            }
        }

        private static  int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private static int InputNumber()
        {
            int input;
            Console.Write("Hey You! Give me a number! ");
            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.WriteLine("Not a number.  Give me a number: ");
            }

            
            return input;

        }
    }
}
