using System;
using System.Threading;

namespace MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            string question = "What is the exam score for Exam #";
            double iterations = 1;

            Console.WriteLine($"{question}1");
            double answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a second exam score? Y/N");
            string AnotherIteration = Console.ReadLine();



            do
            {
                iterations += 1;
                Console.WriteLine($"{question}{iterations}");
                Console.ReadLine();
                Console.WriteLine("Do you have a second exam score? Y/N");
                AnotherIteration = Console.ReadLine();

            } while (AnotherIteration == "Y");
            
            /*while (AnotherIteration == "Y")
            {
                iterations =+ 1;
                Console.WriteLine($"{question}{iterations}");
            }
            */
            
            
            
            
            
            Console.ReadKey();
             
        }
    }
}
