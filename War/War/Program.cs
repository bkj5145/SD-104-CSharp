using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {

            int player1 = 0;
            int player2 = 0;
            bool gameOver = false;
            int warPoints = 0;
            Deck gameDeck = new Deck();

            gameDeck.Shuffle();
            bool war = false;

            while (gameOver == false)
            {
                Card player1card = gameDeck.Draw();
                Console.WriteLine("Player 1 has: "+ player1card.ToString());
                Card player2card = gameDeck.Draw();
                Console.WriteLine("Player 2 has: "+ player2card.ToString());



                if (player1card > player2card)
                {
                    player1 += 2;
                    Console.WriteLine("Player 1 wins: " + player1 + "points");
                    Console.WriteLine();
                }
                else if (player2card.GreaterThan(player1card))
                {
                    player2 += 2;
                    Console.WriteLine("Player 2 wins: " + player2 + "points");
                    Console.WriteLine();
                }
                if (player1card.Equals(player2card))
                {
                    war = true;
                    Console.WriteLine("War!!!!");
                    while (war)
                    {
                        warPoints += 2;
                        player1card = gameDeck.Draw();
                        Console.WriteLine("Player 1 has "+ player1card.ToString());
                        player2card = gameDeck.Draw();
                        Console.WriteLine("Player 2 has " + player2card.ToString());

                        if (player1card.GreaterThan(player2card))
                        {
                            player1 += warPoints;
                        }
                        else if (player2card.GreaterThan(player1card))
                        {
                            player2 += warPoints;
                        }
                    }
                    warPoints = 0;
                    
                }

                if (gameDeck.theCards.Count == 0)
                {
                    gameOver = true;
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
