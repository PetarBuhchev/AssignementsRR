namespace Homework04._12._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.StudentName = "Test";
            st1.EGN = "8593485034";
            st1.GradeBel = 3.6;
            st1.GradeMath = 4.5;
            Student st2 = new Student();
            st2.StudentName = "Test2";
            st2.EGN = "8593454353";
            st2.GradeBel = 5.4;
            st2.GradeMath = 6.0;
            Student st3 = new Student();
            st3.StudentName = "Tes3";
            st3.EGN = "1111112222";
            st3.GradeBel = 2.5;
            st3.GradeMath = 5.4;
            Student st4 = new Student();
            st4.StudentName = "Test4";
            st4.EGN = "5839105839";
            st4.GradeBel = 3.2;
            st4.GradeMath = 4.5;

            Console.WriteLine(st1.ReceiveIncome() ? "Receive" : "Dont receive");
            st2.SetExcellentGrades();
            Class class1 = new Class("Class1", st1, st2, st3);
            Console.WriteLine(class1.CalculateAverageGrade());

            double minGrade = 0; double maxGrade = 0;
            class1.GetMinMaxGrade(ref minGrade, ref maxGrade);
            Console.WriteLine($"Min grade {minGrade}, Max grade {maxGrade}");
            class1.ChangeStudent(ref class1, st4);
            class1.Print();
        }
    }
}