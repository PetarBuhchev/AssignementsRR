using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_26
{
    internal class Student : Human
    {
        private readonly double grade;

        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.grade = grade;
        }
        public override string ToString()
        {
            return base.ToString() + $", grade: {this.grade:f2}";
        }
    }
}
