using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqvane
{
    internal class Student : Person
    {
        public static int countStudents = 0;
        public double averageGrade;

        public Student() : base("Unknown", "Unknown", 0)
        {
            this.averageGrade = 6;
            countStudents++;
        }
        public Student(string firstName, string lastName, int age, double avrgGrade) : base(firstName, lastName, age)
        {
            this.averageGrade = avrgGrade;
            countStudents++;
        }

        public override string GetFullName()
        {
            return base.GetFullName() + " " + this.averageGrade;
        }

        public bool IsExcellentStudent()
        {
            if (this.averageGrade > 5.5)
            {
                return true;
            }
            return false;
        }
    }
}
