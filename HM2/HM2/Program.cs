using System;

namespace HM2
{
    class Program
    {
        //Connor Haigh 113408657
        static void Main(string[] args)
        {
            
            double AccountingGrade;
            double MarketingGrade;
            double EconomicsGrade;
            double MISGrade;
            string AGrade;
            string MGrade;
            string EGrade;
            string MIGrade;
            int A = 90;
            int B = 80;
            int C = 70;
            int D = 60;
            //int LA = 4;
            //int LB = 3;
            //int LC = 2;
            //int LD = 1;
            //int LF = 0;
            double AA;
            double MA;
            double E;
            double M;



            Console.WriteLine("What is your grade in Accounting?");
            AccountingGrade = Convert.ToDouble(Console.ReadLine());
            if (AccountingGrade>=A)
            {
                //Console.WriteLine("Your grade in Accounting is an A");
                AGrade = "A";
                AA = 12;
            }
            else if (AccountingGrade >= B)
            {
                //Console.WriteLine("Your grade in Accounting is a B");
                AGrade = "B";
                AA = 9;
            }
            else if (AccountingGrade >= C)
            {
                //Console.WriteLine("Your grade in Accounting is a C");
                AGrade = "C";
                AA = 6;
            }
            else if (AccountingGrade >= D)
            {
               // Console.WriteLine("Your grade in Accounting is a D");
                AGrade = "D";
                AA = 3;
            }    
            else
            {
               // Console.WriteLine("Your grade in Accounting is a F");
                AGrade = "F";
                AA = 0;
            }
            Console.WriteLine("What is your grade in Marketing?");
            MarketingGrade = Convert.ToDouble(Console.ReadLine());
            if (MarketingGrade >= A)
            {
                //Console.WriteLine("Your grade in Marketing is an A");
                MGrade = "A";
                MA = 12;
            }
            else if (MarketingGrade >= B)
            {
                //Console.WriteLine("Your grade in Marketing is a B");
                MGrade = "B";
                MA = 9;
            }
            else if (MarketingGrade >= C)
            {
                //Console.WriteLine("Your grade in Marketing is a C");
                MGrade = "C";
                MA = 6;
            }
            else if (MarketingGrade >= D)
            {
                //Console.WriteLine("Your grade in Marketing is a D");
                MGrade = "D";
                MA = 3;
            }
            else
            {
                //Console.WriteLine("Your grade in Marketing is a F");
                MGrade = "F";
                MA = 0;
            }
            Console.WriteLine("What is your grade in Economics?");
            EconomicsGrade = Convert.ToDouble(Console.ReadLine());
            if (EconomicsGrade >= A)
            {
                //Console.WriteLine("Your grade in Economics is an A");
                EGrade = "A";
                E = 12;
            }
            else if (EconomicsGrade >= B)
            {
                //Console.WriteLine("Your grade in Economics is a B");
                EGrade = "B";
                E = 9;
            }
            else if (EconomicsGrade >= C)
            {
               // Console.WriteLine("Your grade in Economics is a C");
                EGrade = "C";
                E = 6;  
            }
            else if (EconomicsGrade >= D)
            {
                //Console.WriteLine("Your grade in Economics is a D");
                EGrade = "D";
                E = 3;  
            }
            else
            {
                //Console.WriteLine("Your grade in Economics is a F");
                EGrade = "F";
                E = 0;  
            }
            Console.WriteLine("What is your grade in MIS?");
            MISGrade = Convert.ToDouble(Console.ReadLine());
            if (MISGrade >= A)
            {
                //Console.WriteLine("Your grade in MIS is an A");
                MIGrade = "A";
                M = 12;
            }
            else if (MISGrade >= B)
            {
                //Console.WriteLine("Your grade in MIS is a B");
                MIGrade = "B";
                M = 9;
            }
            else if (MISGrade >= C)
            {
                //Console.WriteLine("Your grade in MIS is a C");
                MIGrade = "C";
                M = 6;
            }
            else if (MISGrade >= D)
            {
                //Console.WriteLine("Your grade in MIS is a D");
                MIGrade = "D";
                M = 3;
            }
            else
            {
                //Console.WriteLine("Your grade in MIS is a F");
                MIGrade = "F";
                M = 0;
            }

            Console.WriteLine("Your grade in Accounting is " + AGrade);
            Console.WriteLine("Your grade in Marketing is " + MGrade);
            Console.WriteLine("Your grade in Economics is " + EGrade);
            Console.WriteLine("Your grade in MIS is " + MIGrade);

            double CreditHours = 12;
            double GPAInput;
            string GPA;

            GPAInput = (AA + MA + E + M)/CreditHours;
            //Console.WriteLine(AA + MA + E + M);
            //Console.WriteLine(CreditHours);
            //GPA = GPAInput.ToString("D2");
            //(GPAInput, 2);
            //GPA = Convert.ToDouble(GPAInput);
            GPA = String.Format("{0:0.##}", GPAInput); // Found this conversion on Grepper... the convert to string ("D2") wasn't working.
            Console.WriteLine("Your GPA is " + GPA);
                
            Console.ReadKey();
        }
    }
}
