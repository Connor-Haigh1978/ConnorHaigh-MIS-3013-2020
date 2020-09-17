using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0; 
            
            for (int i = 1; i < 101; i++)
            {
                sum = sum + i;               
            }

            Console.WriteLine($" The sum of values from 1 - 100 is {sum}");

            int iterations = 0;
            string response;
            do
            {
                iterations += 1;
                Console.WriteLine("Do you want to perform another iteration, yes or no? >>");
                response = Console.ReadLine();

            } while (response.ToLower() == "yes");

            Console.WriteLine($"The number of iterations (or times we asked the user) was {iterations}");

            Console.ReadKey();
        }
    }
}
