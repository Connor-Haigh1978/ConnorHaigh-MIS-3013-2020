using System;

namespace MethodsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an animal please (cow, goat, monkey)");
            string Animal = Console.ReadLine().ToLower();
            string noise = AnimalNoise(Animal);
            Console.ReadKey();
 
        }
        static string AnimalNoise(string Noise)
        {
            
            if (Noise == "cow")
            {
                Console.WriteLine("MOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
            }
            if (Noise == "monkey")
            {
                Console.WriteLine("FGOUYFIYGOHUPIUFGPIGPIG");
            }
            if (Noise == "goat")
            {
                Console.WriteLine("*Lebron James Makes Noises*");
            }
            else
            {
                Console.WriteLine("Input valid animal");
            }
            return Noise;
        }

    }
}
