using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            //WordDictionary<string, int> Counts = new Dictonary<string, int>(); 

            string FilePath = @"C:\Users\conno\Downloads\Jane Eyre.txt";
            string[] lines = File.ReadAllLines(FilePath);
            string line;
            string[] words;


            int count;
            
            bool AnotherIteration = true;

            Dictionary<string, int> ItemCount = new Dictionary<string, int>();
            string word;

            do
            {
                string question = "What word would you like to look for in Jane Eyre?";
                Console.WriteLine(question);
                word = Console.ReadLine();
                count = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    line = lines[i];

                    if (line.Contains(","))
                    {
                        line = line.Replace(",", " ");
                    }
                    if (line.Contains("."))
                    {
                        line = line.Replace(".", " ");
                    }
                    if (line.Contains(";"))
                    {
                        line = line.Replace(";", " ");
                    }
                    if (line.Contains(":"))
                    {
                        line = line.Replace(":", " ");
                    }
                    if (line.Contains("("))
                    {
                        line = line.Replace("(", " ");
                    }
                    if (line.Contains(")"))
                    {
                        line = line.Replace(")", " ");
                    }
                    if (line.Contains("?"))
                    {
                        line = line.Replace("?", " ");
                    }
                    if (line.Contains("_"))
                    {
                        line = line.Replace("_", " ");
                    }
                    words = line.Split(" ");

                    foreach (var item in words)
                    {
                        if (item == word)
                        {
                            count++;
                        }
                    }

                }
                ItemCount.Add(word, count);
                if (count == 0)
                {
                    Console.WriteLine("Word cannot be found");
                }
                Console.WriteLine("Would you like to look for another word? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    AnotherIteration = true;
                }
                else
                {
                    AnotherIteration = false;
                }


            } while (AnotherIteration);

            Console.WriteLine("Jane Eyre Dictionary");
            Console.WriteLine("Word           Count");
            foreach (var input in ItemCount)
            {
                Console.WriteLine("{0}               {1}", input.Key, input.Value);  //found this on this website https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-all-items-of-a-dictionary-with-C-Sharp/
                                                                                     // Console.WriteLine($"{ItemCount.Keys}           {ItemCount.Values}");
            }

            Console.ReadKey();


            //string iteration = "Do you want another iteration";
            //bool AnotherIteration = true;
            //Dictionary<string, int> ItemCount = new Dictionary<string, int>();
            //int count = 0;

            //do
            //{
            //    Console.WriteLine("question");
            //    string word = Console.ReadLine();
            //    Console.WriteLine(iteration);
            //    count++;
            //    ItemCount.Add(word, count);
            //    if (Console.ReadLine().ToLower() == "y")
            //    {
            //        AnotherIteration = true;
            //    }
            //    else
            //    {
            //        AnotherIteration = false;
            //    }
            //} while (AnotherIteration);
            //foreach (var word in ItemCount)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadKey();



        }
    }
}
