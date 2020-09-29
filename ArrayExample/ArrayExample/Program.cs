using System;
using System.Collections.Generic;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] StudentIDs = new int[3];
            double[] StudentGPAs = new double[3];
            
            StudentIDs[0] = 1;
            StudentIDs[1] = 2;
            StudentIDs[2] = 3;

            StudentGPAs[0] = 1.75;
            StudentGPAs[1] = 2.99;
            StudentGPAs[2] = 4.0;

            for (int i = 0; i < StudentIDs.Length; i++)
            {
                int studentID = StudentIDs[i];
                Console.WriteLine(studentID);
            }
            
            foreach (int studentid in StudentIDs)
            {
                Console.WriteLine(studentid);
            }

            Console.WriteLine("Please pick an ID to display the GPA of");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < StudentIDs.Length; i++)
            {
                int studentID = StudentIDs[i];
                if (studentID == id)
                {
                    double gpa = StudentGPAs[i];
                    Console.WriteLine($"Student with {studentID} has a gpa of {gpa}");
                    break;
                }
            }
            

            Dictionary<int, double> studentGpas = new Dictionary<int,double> ();
            if (studentGpas.ContainsKey(1) == true)
            {
                studentGpas[1] = 1.7;
            }
            else
            {
                studentGpas.Add(1, 1.7);
            }

            studentGpas.Add(2, 3.5);
            studentGpas.Add(3, 4.0);

            foreach (var studentID in studentGpas.Keys)
            {
                Console.WriteLine(studentID);
            }

            Console.WriteLine("Please pick an ID to display the GPA of");
            int id1 = Convert.ToInt32(Console.ReadLine());
            if (studentGpas.ContainsKey(id) == true)
            {
                double gpa = studentGpas[id];
                Console.WriteLine($"Student with id {id1} has a gpa of {gpa}");
            }
            else
            {
                Console.WriteLine("Invalid ID, Goodbye");
            }
            Console.ReadKey();
        }
    }
}
