using System;
using System.Collections.Generic;
using System.Text;

namespace P__Toys
{
    public class Toy
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }

        public Toy()
        {
            Manufacturer = "n/a";
            Name = "n/a";
            Price = 0;
            Notes = "n/a";
        }
        public Toy(string manufacturer, string name, double price, string notes)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public string GetAisle()
        {
            char FirstLetter;
            FirstLetter = Manufacturer[0];
            string CapitalizedFirstLetter = FirstLetter.ToString().ToUpper();
            Random rnd = new Random();
            int number = rnd.Next(0, 24);
            string result = CapitalizedFirstLetter + "-" + number;
            return result;

        }
    }
}
