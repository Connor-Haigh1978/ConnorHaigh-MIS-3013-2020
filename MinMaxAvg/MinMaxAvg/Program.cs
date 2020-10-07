using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Transactions;

namespace MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            double iterations = 1;
            string answer2;
            List<double> ExamScores = new List<double>();
            
            ;

            Console.WriteLine($"What is your exam score for exam #{iterations}");
            double answer = Convert.ToDouble(Console.ReadLine());
            double max = answer;
            double min = answer;
            ExamScores.Add(answer);

            Console.WriteLine("Do you have another exam score? Y/N");
            string AnotherIteration = Console.ReadLine().ToUpper();

            if (AnotherIteration == "Y")
            {
                do
                {
                    iterations += 1;
                    Console.WriteLine($"What is your exam score for exam #{iterations}");
                    answer = Convert.ToDouble(Console.ReadLine());
                    ExamScores.Add(answer);
                    Console.WriteLine("Do you have another exam score? Y/N");
                    answer2 = Console.ReadLine().ToUpper();
                } while (answer2 == "Y");
            }
            for (int i = 0; i < ExamScores.Count; i++)
            {
                if (ExamScores[i] > max)
                {
                    max = ExamScores[i];
                }
                if (ExamScores[i] < min)
                {
                    min = ExamScores[i];
                }
            }
            Double ExamTotal = 0;
            foreach  (double number in ExamScores)
            {
                ExamTotal += number; 
            }
            //Console.WriteLine(ExamTotal);
            double average = ExamTotal / iterations;
            string AverageOutput = average.ToString("0.00"); //The "D2" wasn't working for me so I found 0.00 on the docs.microsoft website
            Console.WriteLine($"The min score is {min}\nThe max score is {max}\nThe average score is {AverageOutput}");




            Console.ReadKey();
             
        }
    }
}
