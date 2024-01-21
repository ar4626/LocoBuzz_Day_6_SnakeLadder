using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            int[] playerPositions = { 0, 0 };
            int[] countDice = { 0, 0 };
            int currentPlayer = 0;

            while (true)
            {
                countDice[currentPlayer]++;
                Console.WriteLine($"Player {currentPlayer + 1} is at position {playerPositions[currentPlayer]}");

                int dice = RollDice();
                int option = chechOption();
                Console.WriteLine($"Player {currentPlayer + 1} rolled dice {dice} got option {option}");

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"No Play, Player {currentPlayer + 1} stays at the same position.");
                        break;
                    case 2:
                        if (playerPositions[currentPlayer] + dice <= 100)
                        {

                        playerPositions[currentPlayer] += dice;
                        }
                        Console.WriteLine($"Player {currentPlayer + 1} got a Ladder! Move ahead by {dice} position");
                        break;
                    case 3:
                        if (playerPositions[currentPlayer] >= dice)
                        {
                            playerPositions[currentPlayer] -= dice;
                        }
                        Console.WriteLine($"Player {currentPlayer + 1} got a Snake! Move behind by {dice} position");
                        break;
                }

                if (playerPositions[currentPlayer] == 100)
                {
                    Console.WriteLine($"Player {currentPlayer + 1} WON the game.");
                    break;
                }

                // Switch to the other player for the next turn
                if (option == 1 || option == 3)
                {
                    currentPlayer = (currentPlayer + 1) % 2;
                }

            }

            Console.WriteLine($"Player 1 rolled the dice {countDice[0]} times.");
            Console.WriteLine($"Player 2 rolled the dice {countDice[1]} times.");
            Console.WriteLine($"Player 1 is at {playerPositions[0]} .");
            Console.WriteLine($"Player 2 is at {playerPositions[1]} .");
            Console.ReadLine();
        }

        static int RollDice()
        {
            Random dice = new Random();
            return dice.Next(1, 7);
        }

        static int chechOption()
        {
            Random option = new Random();
            return option.Next(1, 4);
        }
    }
}