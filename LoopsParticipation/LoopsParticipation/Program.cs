using System;
using System.ComponentModel.DataAnnotations;

namespace LoopsParticipation
{
    class Program
    {
        const string Devloper = "Connor Haigh";
        static void Main(string[] args)
        {

            string Question1 = "Guess A Max Number";
            string Question2 = "Guess A Min Number";
            int Guess; 

            Console.WriteLine(Question1);
            string Answer1 = Console.ReadLine();
            Console.WriteLine(Question2);
            string Answer2 = Console.ReadLine();

            Console.WriteLine($"Your min number is {Answer1} and your max number is {Answer2}");
           
            int PreAnswer = Int32.Parse(Answer1); //Found this conversion on microsofts website
            int Max = PreAnswer + 1;
            int Min = Int32.Parse(Answer2);

            Random rnd = new Random();
            int result = rnd.Next(Min, Max);

            Console.WriteLine("Guess your number!");
            String GuessInput = Console.ReadLine();
            Guess = Int32.Parse(GuessInput);

            while (Guess != result)
            {
                Console.WriteLine("Wrong, guess again!");
                Guess = Int32.Parse(Console.ReadLine());
            } 
            
            Console.WriteLine($"{result} is the correct answer");
            
            Console.ReadKey();        
        }


    }
}
