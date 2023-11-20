using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int actualPlayerDice = 0;
            int actualEnemyDice = 0;
            int sumOfPlayerDices = 0;
            int sumOfEnemyDices = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("\nYou rolled a " + playerRandomNum);

                Console.WriteLine("...");

                System.Threading.Thread.Sleep(1000);
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("The enemy AI rolled a " + enemyRandomNum);

                actualPlayerDice = playerRandomNum;
                actualEnemyDice = enemyRandomNum;

                if (actualPlayerDice > actualEnemyDice)
                {
                    Console.WriteLine("You won this round! \n");
                }
                else if (actualPlayerDice < actualEnemyDice)
                {
                    Console.WriteLine("You lost this round! \n");
                } else
                {
                    Console.WriteLine("You have draw this round! \n");
                }

                sumOfPlayerDices += playerRandomNum;
                sumOfEnemyDices += enemyRandomNum;
            }

            Console.WriteLine("Your total score is " + sumOfPlayerDices);
            Console.WriteLine("The enemy AI scored " + sumOfEnemyDices);

            if (sumOfPlayerDices > sumOfEnemyDices)
            {
                Console.WriteLine("\nCongratulations. You have won by a difference of " + (sumOfPlayerDices - sumOfEnemyDices));
            }
            else if (sumOfPlayerDices > sumOfEnemyDices)
            {
                Console.WriteLine("\nUnfortunately, you have lost by a difference of " + (sumOfEnemyDices - sumOfPlayerDices));
            } else
            {
                Console.WriteLine("\nWe have a draw!");
            }

            Console.ReadKey();
            
        }
    }
}
