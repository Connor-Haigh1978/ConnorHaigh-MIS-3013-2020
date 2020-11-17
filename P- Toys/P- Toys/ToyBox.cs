using System;
using System.Collections.Generic;
using System.Text;

namespace P__Toys
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }


            public ToyBox()
        {
            Toys = new List<Toy>();
        }
        public string GetRandomToy()
        {
            int ToyBoxCount = Toys.Count; 
            Random rnd = new Random();
            int number = rnd.Next(0, ToyBoxCount);
            string result = $"The name of the toy is {Toys[number].Name}, the manufacturer is {Toys[number].Manufacturer}, the price is {Toys[number].Price}, the notes on the toy is {Toys[number].Notes}, the aisle is {Toys[number].GetAisle()}";
            //Console.WriteLine(result);

            return result;
        }

    }
}
