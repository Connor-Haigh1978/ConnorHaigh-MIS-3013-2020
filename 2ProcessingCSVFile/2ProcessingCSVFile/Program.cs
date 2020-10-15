using System;
using System.IO;

namespace _2ProcessingCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Transaction_date = 0
             * Payment = 3
             * Name = 4
             * Country = 7
             * 
             * */
            
            string filepath = @"C:\Users\conno\Downloads\SalesJan2009.csv";
            string[] lines = File.ReadAllLines(filepath);
            int q = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string date = pieces[0];
                //string payment = pieces[3];
                string name = pieces[4];
                //string country = pieces[7];
                //bool condition = (payment.ToLower() == "visa" || country.ToLower() == "united states");

                if (pieces[3].ToLower() == "visa" & pieces[7].ToLower() == "united states")
                {
                    Console.WriteLine($"{name} {date}");
                    q += 1; // this is how I checked I got the right amount of values.
                }

            }

            Console.WriteLine(q);
            Console.ReadKey();
           
        }
    }
}
