using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConditionalStringParticipation
{
    class Program
    {   // Connor Haigh 113408657
        const string Class = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(Class);
            string question1 = "What word would you like to look for in the above sentence?:";
            Console.WriteLine(question1);
            string answer1 = Console.ReadLine();
            bool a1 = Class.Contains(answer1);

            if (a1)
            {
                //int index = Class.IndexOf(answer1);
                //if (index >= 0)
                    //Console.WriteLine(answer1 + " begins at character position " + index); this helped me visualize how the index function worked and how I could use this to insert the new word
                string question2 = "What word do you want to change " + answer1 + " to?";
                Console.WriteLine(question2);
                string answer2 = Console.ReadLine();
                var replacement = Class.Replace(answer1, answer2); // found this replacement function on docs.microsoft.com
                Console.WriteLine(replacement);
                //Environment.Exit(-900);
            }

            else
            {
                Console.WriteLine("Sorry, I could not find your word " + answer1);

                string InstanceOfString = answer1; 
                for (int i = InstanceOfString.Length - 1; i > -1; i--)
                    {
                    char letter = InstanceOfString[i];
                    Console.Write(letter);

                }

            }





                 

            //string answer2 = "LIT";
            
            Console.ReadKey();
        }
    }
}
