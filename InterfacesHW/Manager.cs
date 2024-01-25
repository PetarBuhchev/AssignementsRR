using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHW
{
    internal class Manager : Employee, IPerson
    {
        private string department;

        public Manager(string name, int age, string department) : base(name, age)
        {
            this.department = department;
        }

        void IPerson.ToString()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}, Department: {this.department}, IsAdult: {(this.IsAdult() ? "yes" : "no")}");
        }
    }
}
