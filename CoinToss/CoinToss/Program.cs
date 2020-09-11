using System;

namespace CoinToss
{
    class Program
    {
        //Connor Haigh 113408657
        const string DEVELOPER = "Connor Haigh";
        const int Heads = 1;
        const int Tails = 0;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 2);
            Console.WriteLine("Heads or Tails?:");
            string answer = Console.ReadLine();

            if (number == 1 && answer == "Heads")
            {
                Console.WriteLine("It's Heads! You've Won!");
            } 
            else if (number == 2 && answer == "Tails")
            {
                Console.WriteLine("It's Tails! You've Won!");
            }
            else
            {
                Console.WriteLine("Wrong Choice Loser!");

            }        
        
        }   
        

	}
}
