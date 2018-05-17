/*
 * Project:  Lab 2 Calculate Batting Average
 *      Date: 3-16-2017
 *      Author:  J. Monroe
 *      Notes:  This program reads in a baseball player's name,
 *      number of hits and number of at bats.
 *      The player's batting average is calculated and displayed.
 *      */

 
using System;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            double nHits, nAtBats;
            double dblBattingAverage;

            //propmpt for name and receive
            Console.WriteLine("~This program calculates a baseball player's batting average~");
            Console.WriteLine("<-------------------------------------------------------------->");
            Console.WriteLine("");
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = "Brian";  //Console.ReadLine();
            Console.WriteLine(strPlayerName);

            //prompt for hits
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());


            dblBattingAverage = nHits / nAtBats;

            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();



        }
    }
}
