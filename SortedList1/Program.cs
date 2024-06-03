using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, List<double>> sl = new SortedList<string, List<double>>();
            string inputName = Console.ReadLine();
            while (inputName != "stop")
            {
                if (!sl.ContainsKey(inputName))
                {
                    string inputGrades = Console.ReadLine();
                    while (inputGrades != "end")
                    {
                        sl[inputName].Add(double.Parse(inputGrades));
                        inputName = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Това име вече съществува!");
                    inputName = Console.ReadLine();
                }
            }

            SortedList<double, string> studentsWithAvrgGrades = new SortedList<double, string>();

            foreach (var student in sl)
            {
                double sum = 0;
                int count = 0;

                for (int i = 0; i < student.Value.Count; i++)
                {
                    sum += student.Value[i];
                    count++;
                }
                double avrg = sum * 1.0 / count;

                studentsWithAvrgGrades.Add(avrg, student.Key);
            }

            double max = studentsWithAvrgGrades.Keys.Max();
            Console.WriteLine($"Grade: {max} - Name: {studentsWithAvrgGrades[max]}");
            studentsWithAvrgGrades.Remove(max);
        }
    }
}
