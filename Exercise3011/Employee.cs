using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3011
{
    public class Employee
    {
        public string name;
        public string position;
        public double salary;
        private int experience;

        public int Experience
        {
            get { return this.experience; }
            set
            {
                if (value >= 1 && value <= 40)
                {
                    this.experience = value;
                }
                else
                {
                    Console.WriteLine("Грешка при въвеждането на трудов стаж");
                }
            }
        }

        public Employee()
        {
            this.name = "unknown";
            this.position = "unknown";
            this.salary = 0;
            this.experience = 1;
        }
        public Employee(string name, string position, double salary, int experience)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            Experience = experience;
        }
    }
}
