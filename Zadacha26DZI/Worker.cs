using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_26
{
    internal class Worker : Human
    {
        private readonly double wage;
        private readonly int workHours;

        public Worker(string firstName, string lastName, int age, double wage, int workHours) : base(firstName, lastName, age)
        {
            this.wage = wage;
            this.workHours = workHours;
        }

        public double Salary()
        {
            return this.wage * this.workHours;
        }
        public override string ToString() 
        {
            return base.ToString() + $", salary: ${this.Salary():f2}";
        }
    }
}
