using System;

namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
            //string firstName, lastName;
            string firstName = "Connor";
            string lastName = "Haigh";

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine(); //Getting what user type and storing variable

            Console.WriteLine("Please enter your last name>>");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            double gpaEnhanced = gpa + 1.5;

            Console.WriteLine(firstName + ' ' + lastName +
                " is teaching " + CLASS_NAME +
                " with a GPA of " + gpa.ToString("N2"));

        }
    }
}
