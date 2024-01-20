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
            int playerPosition = 0;

           while (playerPosition < 101)
            {
                Console.WriteLine($"Player is at position {playerPosition}");
                //Console.WriteLine("Press Enter to Roll Dice");
                //Console.ReadLine();

                int dice = RollDice();
                Console.WriteLine($"Rolled dice {dice}");

                int option = chechOption();
                Console.WriteLine($"Player got option {option}");   

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"No Play, Stay at the same position."); 
                        break;
                    case 2:
                        playerPosition += dice;
                        Console.WriteLine($"Ladder! Move ahead by {dice} position");
                        break;
                    case 3:
                        if (playerPosition >= dice)
                        {
                            playerPosition -= dice;
                        }
                        Console.WriteLine($"Snake! Move behind by {dice} position");
                        break;
                }

                /*if (playerPosition == 100)
                {
                    Console.WriteLine("YEEE! You WON the game.");
                    break;
                }*/

           }
            Console.ReadLine();
        }

        static int RollDice()
        {
            Random dice = new Random();
            return dice.Next(1,7);
        }

        static int chechOption()
        {
            Random option = new Random();
            return option.Next(1,4);
        }
    }
}
