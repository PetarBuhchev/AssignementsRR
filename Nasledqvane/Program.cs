using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan", "Ivanov", 20);
            Console.WriteLine(p1.GetFullName());

            Student s1 = new Student();
            Student s2 = new Student("Asen", "Petrov", 16, 5.4);

            Console.WriteLine(s1.GetFullName());
            Console.WriteLine(s1.IsExcellentStudent() ? "excellent" : "not excellent");
            
            Console.WriteLine(s2.GetFullName());
            Console.WriteLine(s2.IsExcellentStudent() ? "excellent" : "not excellent");

            Console.WriteLine($"Students: {Student.countStudents}");

            Teacher t1 = new Teacher("Ana", "Metodieva", 42, 2500);
            Teacher t2 = new Teacher("Dimitar", "Dimitrov", 35, 2000);

            Console.WriteLine(t1.GetFullName());
            Teacher.IncreaseSalary(t1, 500);

            Console.WriteLine(t2.GetFullName());
            Teacher.IncreaseSalary(t2, 600);
        }
    }
}
