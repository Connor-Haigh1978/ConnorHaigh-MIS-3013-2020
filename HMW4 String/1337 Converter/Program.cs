using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _1337_Converter
{
    class Program
    {       //ConnorHaigh 113408657
        static void Main(string[] args)
        {
 
            Console.WriteLine("Write me a sentence");
            string sentence = Console.ReadLine();
            //bool exc = sentence.Contains('!');
            if (sentence.Contains('A'))
            {
               sentence = sentence.Replace('A', '4');
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains('E'))
            {
                sentence = sentence.Replace('E', '3');
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains("H"))
            {
                sentence = sentence.Replace("H", "|-|");
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains('S'))
            {
                sentence = sentence.Replace('S', '$');
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains('T'))
            {
                sentence = sentence.Replace('T', '7');
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains("U"))
            {
                sentence = sentence.Replace("U", "|_|");
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains('O'))
            {
                sentence = sentence.Replace('O', '0');
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains("P"))
            {
                sentence = sentence.Replace("P", "[]D");
                //Console.WriteLine(sentence);
            }
            if (sentence.Contains("!"))
            {
                Console.WriteLine(sentence);

            }
            else if (sentence.Contains("!") == false)
            {
                Console.WriteLine($"{sentence}!");
            }

            
            Console.ReadKey();
           
        }
    }
}

