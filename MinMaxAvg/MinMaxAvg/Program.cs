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
            /*List<string> favoriteThings = new List<string>();
            string answer;

             do
            {
                Console.WriteLine("Please enter one of your favorite things");
                string favoriteThing = Console.ReadLine();

                favoriteThings.Add(favoriteThing);

                Console.WriteLine("Do you have another favorite thing?");
                answer = Console.ReadLine();


            } while (answer.ToLower() == "yes");

            Random rand = new Random();
            int index = rand.Next(0, favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);

            //foreach (var item in collection)
            //{

            //}



            */

            /*List<double> examScores = new List<double>();
            string question = "What is the exam score for Exam #";
            double iterations = 1;

            Console.WriteLine($"{question}1");
            double answer; //= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a second exam score? Y/N");
            string AnotherIteration;


            if (AnotherIteration.ToUpper() == "Y");
            {

            }
            do
            {
                iterations += 1;
                Console.WriteLine($"{question}{iterations}");
                answer = Convert.ToInt32(Console.ReadLine());
                examScores.Add(answer);
                
                Console.WriteLine("Do you have a second exam score? Y/N");
                AnotherIteration = Console.ReadLine();

            } while (AnotherIteration.ToUpper() == "Y");

            while (AnotherIteration == "Y")
            {
                iterations =+ 1;
                Console.WriteLine($"{question}{iterations}");
            }*/

             List<double> examScores = new List<double>();
            double iterations = 1;
            string question = $"What is your exam score for exam {iterations}";
            double answer;
            string AnotherIteration = "Do you have another exam score? Y/N";
            string AnotherIteration2 = "Do you have another exam score? Y/N";
            string answer2;
            string answer3;

            Console.WriteLine(question);
            answer = Convert.ToInt32(Console.ReadLine());
            examScores.Add(answer);


            Console.WriteLine(AnotherIteration);
            answer2 = Console.ReadLine();

            if (answer2.ToUpper() == "Y");
            {
                do
                {
                    iterations += 1;
                    Console.WriteLine($"What is your exam score for exam {iterations}");
                    answer = Convert.ToDouble(Console.ReadLine());
                    examScores.Add(answer);
                    Console.WriteLine(AnotherIteration2);
                    answer3 = Console.ReadLine();

                } while (answer3.ToUpper() == "Y");
            }

            //int i = 0;
            for (int i = -1; i < examScores.Count + 1; i++)
            {
                //i += 1;
                //examScores[i];
                //Console.WriteLine(examScores[i]);
                Console.WriteLine(examScores.Count);
            }
            
            //foreach (var i in examScores)
            //{

            //}

            /*double max = examScores[0];
            foreach  (var answers in examScores)
            {
                Console.Write(answers);
            }
            for (int i=0; i<examScores.Length; )
            


            //double minscore = examScores.Min(answer);

            //foreach (var answers in examScores)
            // {
            //  Console.WriteLine(answers);
            //}

            /*double iterations = 1;
            Console.WriteLine($"What is your score for exam #1");
            double answer = Console.ReadLine();
            string answer2;

            string IterationQuestion = "Do you have another exam score? Y/N";
            Console.WriteLine(IterationQuestion);

            if (IterationQuestion.ToUpper() == "Y") ;
            {
                do
                {
                    iterations += 1;
                    string question2 = $"What is your score for exame #{iterations}";
                    answer = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(IterationQuestion);
                    answer2 = Console.ReadLine();

                } while (answer2.ToUpper() == "Y");


            }
            */
            
            
            
            
            
            
            Console.ReadKey();
             
        }
    }
}
