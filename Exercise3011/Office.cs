using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3011
{
    public class Office
    {
        public string name;
        public Employee employee1;
        public Employee employee2;

        public Office(string name, Employee employee1, Employee employee2)
        {
            this.name = name;
            this.employee1 = employee1;
            this.employee2 = employee2;
        }
        public double MaxSalary()
        {
            if (employee1.salary > employee2.salary)
            {
                return employee1.salary;
            }
            else { return employee2.salary;}
        }
        public void ChangeEmployee(ref Employee employee1, Employee newEmployee)
        {
            employee1 = newEmployee;
        }
        public void Print()
        {
            Console.WriteLine($"Office name: {this.name}");
            Console.WriteLine($"Employee1 name: {this.employee1.name}");
            Console.WriteLine($"Employee1 position: {this.employee1.position}");
            Console.WriteLine($"Employee1 salary {this.employee1.salary}");
            Console.WriteLine($"Employee1 experience: {this.employee1.Experience}");
            Console.WriteLine();
            Console.WriteLine($"Employee2 name: {this.employee2.name}");
            Console.WriteLine($"Employee2 position: {this.employee2.position}");
            Console.WriteLine($"Employee2 salary {this.employee2.salary}");
            Console.WriteLine($"Employee2 experience: {this.employee2.Experience}");
        }
    }
}
