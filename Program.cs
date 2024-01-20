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
                Console.WriteLine("Press Enter to Roll Dice");
                Console.ReadLine();

                int dice = RollDice();
                Console.WriteLine($"Rolled dice {dice}");
            }
        }

        static int RollDice()
        {
            Random dice = new Random();
            return dice.Next(1,7);
        }
    }
}
