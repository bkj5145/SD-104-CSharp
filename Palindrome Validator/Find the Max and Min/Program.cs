using System;

namespace Find_the_Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program is going take user input - number of numbers he is going to write
            //Program is going validate user input - and make sure it is a number
            //Program is going to loop and have the user write a number up to the first number number (size/number of numbers)
            //Program is going to find the max number and the minimum number in the array.
            //Program will output this to the user.

            //hint #1
            int min;
            int max;

            //hint #2
            // min and your max is going to start as the first value in your array.  So arry[0]

            //hint #3
            //min means array[position] < min
            //max means array[position] > max

            Console.Write("How many numbers are in your array?: ");
            int enteredCount;
            while (Int32.TryParse(Console.ReadLine(), out enteredCount) == false)
            {
                Console.WriteLine("Not a number. Please enter a number: ");
            }
            int[] minandMaxArray = new int[enteredCount];

            for (int count = 0; count < minandMaxArray.Length; count++)
            {
                Console.Write("Please enter the value for number " + (count + 1) + ": ");
                while (Int32.TryParse(Console.ReadLine(), out enteredCount) == false)
                {
                    Console.WriteLine("Not a number. Please enter a number: ");
                }
                minandMaxArray[count] = enteredCount;
            }

            min = minandMaxArray[0];
            max = minandMaxArray[0];

            for (int i = 0; i < minandMaxArray.Length; i++)
            {

                if (minandMaxArray[i] < min)
                {
                    min = minandMaxArray[i];
                }
                if (minandMaxArray[i] > max)
                {
                    max = minandMaxArray[i];
                }
            }

            Console.WriteLine("The minimum value is: " + min);
            Console.WriteLine("The max value is: " + max);


            Console.ReadLine();
        }
    }
}
