using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakingChange(5, (decimal)4.13));

            //Calculator();
            Console.ReadKey();

        }

        public static void ChangeDriver()
        {
            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price, (int)price + rnd.Next(20));
                string change = MakingChange(tendered, price);
                exit = GetInput(change);
            }
        }

        private static string MakingChange(int tendered, decimal price)
        {
            int quarters, dimes, nickels, cents;
            decimal change =(tendered - price);

            quarters = (int)(change/.25m);
            change -= (decimal)(quarters * .25);

            dimes = (int)(change / .10m);
            change -= (decimal)(dimes * .10);

            nickels = (int)(change / .05m);
            change -= (decimal)(nickels * .05);

            cents = (int)(change / .01m);
            change -= (decimal)(cents * .01);

            string str = "";
            return  str = string.Format("Quarters: {0}  Dimes: {1}  Nickels:   {2}  Pennies:  {3}", quarters, dimes, nickels, cents);
        }

        public static void Calculator()
        {
            while (true)
            {
                string str = GetInput("Enter Equation: ");
                if (str.Length == 0)
                {
                    break;
                }
                string[] strArray = str.Split(' ');
                double firstValue = GetNumber(strArray[0]);
                double secondValue = 0;

                if (secondValue.Equals(0))
                {
                    secondValue = 1;
                }
                else
                {
                    secondValue = GetNumber(strArray[2]);
                }

                Console.WriteLine(GetResult(firstValue, secondValue, strArray[1]));
            }

        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }

        public static double GetNumber(string strNum)
        {
            double dblNum;
            double.TryParse(strNum, out dblNum);
            return dblNum;
        }

        public static double GetResult(double fValue, double sValue, string opr)
        {   /// Determines the operation that was performed and performs the calculation back 
            switch (opr)
            {
                case "+":
                    return fValue + sValue;
                case "-":
                    return fValue - sValue;
                case "*":
                    return fValue * sValue;
                case "/":
                    return fValue / sValue;
                case "%":
                    return fValue % sValue;
                case "^":
                    return Math.Pow(fValue, sValue);
                case "sqrt":
                    return Math.Sqrt(fValue);
                case "^2":
                    return Math.Pow(fValue, 2);
                default:
                    return 0;
                    


            }
        }
         
    }
}
