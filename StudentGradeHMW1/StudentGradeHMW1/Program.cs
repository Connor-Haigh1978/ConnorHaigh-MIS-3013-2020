using System;

namespace StudentGradeHMW1
{
    class Program
    {
        //Connor Haigh 113408657
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            int StudentID;
            double Homework;
            double Participation;
            double Quiz;
            double Midterm;
            double Final;
            string FinalGrade;

            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your Student ID?");
            string StudentIDInput = Console.ReadLine();
            StudentID = Convert.ToInt32(StudentIDInput); 

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            string HomeworkInput = Console.ReadLine();
            Homework = Convert.ToDouble(HomeworkInput);
            Double HomeworkUse = Homework / 100;

            Console.WriteLine("What is your overall percentage grade for participations?");
            string ParticipationInput = Console.ReadLine();
            Participation = Convert.ToDouble(ParticipationInput);
            Double ParticipationUse = Participation / 100;

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            string QuizInput = Console.ReadLine();
            Quiz = Convert.ToDouble(QuizInput);
            Double QuizUse = Quiz / 100;

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            string MidtermInput = Console.ReadLine();
            Midterm = Convert.ToDouble(MidtermInput);
            Double MidtermUse = Midterm / 100;


            Console.WriteLine("What is your overall percentage grade for the final?");
            string FinalInput = Console.ReadLine();
            Final = Convert.ToDouble(FinalInput);
            Double FinalUse = Final / 100;

            double FinalGradeInput = ((.25 * HomeworkUse) + (.10 * ParticipationUse) + (.25 * MidtermUse) + (.30 * FinalUse) + (.10 * QuizUse));
            FinalGrade = FinalGradeInput.ToString("P2");
            Console.WriteLine(FirstName + " " + LastName + "(" + StudentID + "), your final grade is " + FinalGrade);
        }
    }
}
