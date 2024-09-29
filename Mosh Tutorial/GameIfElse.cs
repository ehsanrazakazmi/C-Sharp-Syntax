using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Tutorial
{
    internal class GameIfElse
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);        // generate random number from 1-6
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }

                Console.WriteLine($"Your score including bonuses is: {total}\n");
            }
            Console.WriteLine("CONGRATULATIONS\t");

            if (total >= 16)
            {
                Console.WriteLine("You have won a Car!");
            }
            else if (total >=10)
            {
                Console.WriteLine("you have won a laptop");
            }
            else if (total == 7)
            {
                Console.WriteLine("You have won a trip");
            }
            else
            {
                Console.WriteLine("You have won a kitten");
            }

        }
    }
}
