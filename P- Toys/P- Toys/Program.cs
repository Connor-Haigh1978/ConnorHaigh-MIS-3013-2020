using System;
using System.Dynamic;

namespace P__Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Toy NewToy = new Toy();
            NewToy.Manufacturer = "Nike";
            NewToy.Name = "Ooga Booga!";
            NewToy.Price = 69;
            NewToy.Notes = "Issa knife";

            Console.WriteLine($"The name of the toy is {NewToy.Name}, the manufacturer is {NewToy.Manufacturer}, the price is {NewToy.Price}, the notes on the toy is {NewToy.Notes}, the aisle is {NewToy.GetAisle()}");
            Console.ReadKey();
        }
    }
}
