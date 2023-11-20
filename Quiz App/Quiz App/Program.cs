using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;



namespace Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("questions.txt");

            List<string> questions = new List<string>();
            List<string> answers = new List<string>();

            for (int i = 0; i < text.Length; i++) { 
                if (i % 4 == 0)
                {
                    questions.Add(text[i]);
                }
                else
                {

                }
            }

            int questionsIndex = 0;
            int answersIndex = 0;
            int score = 0;

            while (questionsIndex < questions.Count)
            {
                Console.WriteLine(questions[questionsIndex]);
                questionsIndex++;

                int correctAnswerIndex = 0;

                for (int i = 0; i < 3; i++)
                {
                    if (answers[answersIndex].StartsWith(">"))
                    {
                        correctAnswerIndex = i + 1;
                    }
                    Console.WriteLine(i + 1 + "." + answers[answersIndex].Replace(">", ""));

                    answersIndex++;
                }

                int answer = int.Parse(Console.ReadLine());

                if (answer == correctAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine("End of quiz! Your score was " + score);
        }
    }
}
