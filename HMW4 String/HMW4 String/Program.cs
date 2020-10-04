using System;

namespace HMW4_String
{
    class Program
    {// Connor Haigh 113408657
        static void Main(string[] args)
        {
            int TotalVowel = 0;
            int TotalConsonants = 0;
            /*string vowel1 = "a";
            string vowel2 = "e";
            string vowel3 = "i";
            string vowel4 = "o";
            string vowel5 = "u";
            */
            Console.WriteLine("Write me a sentance, please:");
            string sentence = Console.ReadLine().ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    TotalVowel++;
                    //Console.WriteLine(i); this helped me find the locations of each vowel
                }
                if (sentence[i] != 'a' & sentence[i] != 'e' & sentence[i] != 'i' & sentence[i] != 'o' & sentence[i] != 'u' ) 
                {
                TotalConsonants++;
                }
            }
            
            Console.WriteLine($" your total amount of vowels is {TotalVowel}");
            Console.WriteLine($" your total amound of consonants is {TotalConsonants}");
            


            Console.ReadKey();
        }

    }
}
