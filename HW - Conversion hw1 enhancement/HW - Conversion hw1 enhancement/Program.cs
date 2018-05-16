using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW___Conversion_hw1_enhancement
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("This program has multiple functionalities");
            Console.WriteLine("A to convert miles to KM, B to convert inches to CM, C to convert lbs to kg");
            Console.WriteLine("D to convert KM to miles, E to convert CM to inches, F to convert kg to lbs");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();

            switch (choice.ToUpper())
            {

                case "A":
                    Console.Write("Please enter the Miles to convert to KM: ");
                    Conversion userValue = new Conversion();
                    userValue.getUserInput();
                    Conversion.milesToKM();      //converts miles to KM
                    break;
                case "B":
                    Console.Write("Please enter the Inches to convert to CM: ");
                    Conversion inches = new Conversion();
                    inches.getUserInput();
                    Conversion.inchesToCM();  //converts miles to KM
                    break;
                case "C":
                    Console.Write("Please enter LBS to convert to KG: ");
                    Conversion lbs = new Conversion();
                    lbs.getUserInput();
                    Conversion.lbsToKG(); //converts miles to KM
                    break;
                case "D":
                    Console.Write("Please enter the KM to convert to Miles: ");
                    Conversion km = new Conversion();
                    km.getUserInput();
                    Conversion.kmToMiles(); //converts m5iles to KM
                    break;
                case "E":
                    Console.Write("Please enter the CM to convert to Inches: ");
                    Conversion cm = new Conversion();
                    cm.getUserInput();
                    Conversion.cmToInches(); //converts miles to KM
                    break;
                case "F":
                    Console.Write("Please enter the KG to convert to LBS: ");
                    Conversion kg = new Conversion();
                    kg.getUserInput();
                    Conversion.kgToLBS();      //converts miles to KM
                    break;
                default:
                    break;


            }
            Console.ReadLine();
        }
    }
}
