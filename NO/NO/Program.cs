using System;

namespace NO
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("How many");
            int itemPrice = Convert.ToInt32(Console.ReadLine());
            int howManyShouldIBuy;

            if (itemPrice < 10)
            {
                howManyShouldIBuy = 50;
            }
            else if (itemPrice > 10 && itemPrice < 20)
            {
                if (itemPrice == 15)
                {
                    howManyShouldIBuy = 40;
                }
                else if (itemPrice > 15)
                {
                    howManyShouldIBuy = 35;
                }
                else
                {
                    howManyShouldIBuy = 30;
                }
            }
            else
            {
                howManyShouldIBuy = 20;
            }
            Console.WriteLine("Your final output is " + howManyShouldIBuy);
            Console.ReadKey(); */

            Console.WriteLine("Value");
            int input = Convert.ToInt32(Console.ReadLine());
            int answer;

            if (input == 10)
            {
                answer = 10 * input;
            }
            else
            {
                answer = input;
            }
            Console.WriteLine("Your output is " + answer);
            Console.ReadKey();
        }
    }
}
