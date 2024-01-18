using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqvane
{
    internal class Teacher : Person
    {
        public static int countTeachers = 0;
        public double Salary { get; set; }

        public Teacher(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age)
        {
            this.Salary = salary;
            countTeachers++;
        }

        public override string GetFullName()
        {
            return $"{this.FirstName} {this.LastName} have {this.Salary}";
        }
        public static void IncreaseSalary(Teacher t1, int addedNum)
        {
            t1.Salary += addedNum;
        }
    }
}
