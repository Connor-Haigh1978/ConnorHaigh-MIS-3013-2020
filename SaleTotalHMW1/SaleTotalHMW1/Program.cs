using System;
using System.Reflection.Metadata;

namespace SaleTotalHMW1
{
    class Program
    {
        // Connor Haigh 113408657
        const double TaxRate = .085;
        static void Main(string[] args)
        {
            string item;
            string QuantityInput;
            string PriceInput;
            double quantity;
            double price;
            double SubTotal;
            double SalesTax;
            double total;

            

            string ItemQuestion = "What is the product name of the item you are purchasing?:";
            //string QuantityQuestion = "How many " + item + " are you purchasing today?";
            //string PriceQuestion = "What is the price of the" + item + "'s";

            Console.WriteLine(ItemQuestion);
            item = Console.ReadLine();

            Console.WriteLine("How many " + item + "'s are you purchasing today?");
            QuantityInput = Console.ReadLine();
            quantity = Convert.ToDouble(QuantityInput);

            Console.WriteLine("What is the price for each " + item + "?");
            PriceInput = Console.ReadLine();
            price = Convert.ToDouble(PriceInput);

            SubTotal = (quantity * price);
            Console.WriteLine("         Your subtotal for your bill is " + SubTotal.ToString("C2"));

            SalesTax = (SubTotal * TaxRate);
            Console.WriteLine("         Your sales tax for your bill is " + SalesTax.ToString("C2"));

            total = (SubTotal + SalesTax);
            
            Console.WriteLine("         Your total for your bill is " + total.ToString("C2"));


        }
    }
}
