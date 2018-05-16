using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW___Conversion_hw1_enhancement
{
    class Conversion
    {
        public static Double number;

        public Conversion()
        {
            number = 0;
        }

        public void getUserInput()
        {
            number = Double.Parse(Console.ReadLine());
        }

        public static void milesToKM()
        {
            double KM = number * 1.6;
            Console.WriteLine("Miles to KM is: " + KM);
        }

        public static void inchesToCM()
        {
            double CM = number * 2.54;
            Console.WriteLine("Inches to CM is: " + CM);
        }
        public static void lbsToKG()
        {
            double KG = number * 0.45359237;
            Console.WriteLine("LBS to KG is: " + KG);
        }
        public static void kmToMiles()
        {
            double Miles = number * 0.62137119;
            Console.WriteLine("KM to Miles is: " + Miles);
        }
        public static void cmToInches()
        {
            double Inches = number * 0.39;
            Console.WriteLine("CM to Inches is: " + Inches);
        }

        public static void kgToLBS()
        {
            double lbs = number * 2.2;
            Console.WriteLine("KG to LBS is: " + lbs);
        }
    }
}
