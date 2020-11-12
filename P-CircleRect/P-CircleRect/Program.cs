using System;
using System.Collections.Generic;
namespace P_CircleRect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();
            List<string> dobs = new List<string>();
            List<string> FavoriteFood = new List<string>();
            List<double> AccountBalance = new List<double>();

            FirstNames.Add("Connor");
            LastNames.Add("Haigh");
            dobs.Add("04/19/2000");
            FavoriteFood.Add("Steak");
            AccountBalance.Add(420690);

            FirstNames.Add("Lil");
            LastNames.Add("Gooch");
            dobs.Add("04/19/1969");
            FavoriteFood.Add("Ass");
            AccountBalance.Add(696969);

            for (int i = 0; i < FirstNames.Count; i++)
            {
                Console.WriteLine($"First Name: {FirstNames[i]}, Last Name: {LastNames[i]}, DOB: {dobs[i]}, Favorite Food:{FavoriteFood[i]}, Account Balance: {AccountBalance[i]} ");
            }


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
