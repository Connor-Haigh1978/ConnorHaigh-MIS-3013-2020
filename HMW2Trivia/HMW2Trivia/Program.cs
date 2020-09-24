using System;
using System.Runtime.CompilerServices;

namespace HMW2Trivia
{
    class Program
    {
        //Connor Haigh 113408657
        static void Main(string[] args)
        {
            string question1 = "This drip permanent (T/F)";
            string question2 = "Can't say Pop without the Smoke (T/F)";
            string question3 = "We want beef not veggies not squash (T/F)";
            string question4 = "Rolly turn me into stone (T/F)";
            string question5 = "Acquiring currency is the game, basketball game is my fame (T/F)";

            string answer1;
            string answer2;
            string answer3;
            string answer4;
            string answer5;

            double R1 = 0;


            string T = "T";
            string F = "F";

            Console.WriteLine(question1);
            answer1 = Console.ReadLine();
            if (answer1 == T || answer1 == F)
            {
                if (answer1 == T)
                {
                    R1 += 1;
                }
                if (answer1 == F)
                {
                    R1 += 0;
                }
            }
            else
            {
                return;
            }
            Console.WriteLine(question2);
            answer2 = Console.ReadLine();
            if (answer2 == T || answer2 == F)
            {
                if (answer2 == T)
                {
                    R1 += 1;
                }
                if (answer2 == F)
                {
                    R1 += 0;
                }
            }
            else
            {
                return;
            }
            Console.WriteLine(question3);
            answer3 = Console.ReadLine();
            if (answer3 == T || answer3 == F)
            {
                if (answer3 == T)
                {
                    R1 += 1;
                }
                if (answer3 == F)
                {
                    R1 += 0;
                }
            }
            else
            {
                return;
            }
            Console.WriteLine(question4);
            answer4 = Console.ReadLine();
            if (answer4 == T || answer4 == F)
            {
                if (answer4 == F)
                {
                    R1 += 1;
                }
                if (answer4 == T)
                {
                    R1 += 0;
                }
            }
            else
            {
                return;
            }
            Console.WriteLine(question5);
            answer5 = Console.ReadLine();
            if (answer5 == T || answer5 == F)
            {
                if (answer5 == T)
                {
                    R1 += 1;
                }
                if (answer5 == F)
                {
                    R1 += 1;
                }
            }
            else
            {
                return;
            }
            double PercentInput = (R1 / 5);
            Console.WriteLine("You got " + R1 +"/5 correct!");
            string Percent = PercentInput.ToString("P");
            Console.WriteLine(Percent);
                Console.ReadKey();
        }

    }
}
