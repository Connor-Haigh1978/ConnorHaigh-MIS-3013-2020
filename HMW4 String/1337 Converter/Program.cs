using System;

namespace _1337_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string sentence = "pppooo";
            Console.WriteLine(sentence);
            Console.WriteLine(sentence.Replace('p','u'));
            

            Console.WriteLine("Please write me a sentence");
            string sentence = Console.ReadLine().ToUpper();
            string h = "H";
            string hC = "|-|";
            string u = "U";
            string uC = "|_|";
            string p = "P";
            string pC = "[]D";

            //for (int i = 0; i < sentence.Length; i++)
            //{
                //if (sentence.Contains("A"))
                //{
                    sentence.Replace("A", "4");
                    Console.WriteLine(sentence);
                //}
            //}
            //Console.WriteLine(sentence);
            Console.ReadKey();
                if (sentence.Contains('E'))
                {
                    sentence.Replace('E', '3');
                }
                if (sentence.Contains(h))
                {
                    sentence.Replace(h, hC);
                }
                if (sentence.Contains('S'))
                {
                    sentence.Replace('S', '$');
                }
                if (sentence.Contains('T'))
                {
                    sentence.Replace('T', '7');
                }
                if (sentence.Contains(u))
                {
                    sentence.Replace(u, uC);
                }
                if (sentence.Contains("O"))
                {
                    sentence.Replace("O", "0");
                }
                if (sentence.Contains(p))
                    sentence.Replace(p, pC);
            }
            
            
            Console.WriteLine(sentence);
            Console.ReadKey();
        */
            Console.WriteLine("Write me a sentence");
            string sentence = Console.ReadLine().ToUpper();

            if (sentence.Contains('E'))
            {
                Console.WriteLine(sentence.Replace('E', '3'));
            }
            if (sentence.Contains('S'))
            {
                Console.WriteLine(sentence.Replace('S', '$'));
            }
            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
