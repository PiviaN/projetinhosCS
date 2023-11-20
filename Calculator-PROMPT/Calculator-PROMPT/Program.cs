using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_PROMPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            string answer;

            int result;
            
            Console.WriteLine("Hello, welcome to the calculator program!");

            Console.WriteLine("Please enter your first number.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or anything for division.");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);

            Console.ReadKey();
        }
    }
}
