using System;
using System.Dynamic;

namespace P__Toys
{
    class Program
    {
        //Connor Haigh 113408657
        static void Main(string[] args)
        {

            Toy NewToy = new Toy();
            ToyBox NewToyBox = new ToyBox();

            Console.WriteLine("Who is the Manufacturer of your toy");
            NewToy.Manufacturer = Console.ReadLine();

            Console.WriteLine("What is the Name of your toy");
            NewToy.Name = Console.ReadLine();

            Console.WriteLine("What is the Price of your toy");
            NewToy.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Any Notes about your toy?");
            NewToy.Notes = Console.ReadLine();

            NewToyBox.Toys.Add(NewToy);

            Console.WriteLine("Do you have another toy? y/n ");
            string iteration = Console.ReadLine().ToLower();
            while (iteration == "y")
            {
                NewToy = new Toy();

                Console.WriteLine("What is the Manufacturer of your toy");
                NewToy.Manufacturer = Console.ReadLine();

                Console.WriteLine("What is the Name of your toy");
                NewToy.Name = Console.ReadLine();

                Console.WriteLine("What is the Price of your toy");
                NewToy.Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Any Notes about your toy?");
                NewToy.Notes = Console.ReadLine();

                Console.WriteLine("Do you have another toy? y/n ");
                iteration = Console.ReadLine().ToLower();

                NewToyBox.Toys.Add(NewToy);

                //new toy and add to collection

            }


            //Console.WriteLine($"The name of the toy is {NewToy.Name}, the manufacturer is {NewToy.Manufacturer}, the price is {NewToy.Price}, the notes on the toy is {NewToy.Notes}, the aisle is {NewToy.GetAisle()}");
            //foreach (var item in NewToyBox.Toys)
            //{
            //    Console.WriteLine($"The name of the toy is {item.Name}, the manufacturer is {item.Manufacturer}, the price is {item.Price}, the notes on the toy is {item.Notes}, the aisle is {item.GetAisle()}");
            //}

            Console.WriteLine($"The random toy is: \n {NewToyBox.GetRandomToy()}");
            Console.ReadKey();
        }
    }
}
