using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHW
{
    internal class Employee : IPerson
    {
        private int age;
        private string name;
        public int Age
        {
            get { return age; }
            private set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Invalid age");
                }
            } 
        }
        public string Name { 
            get { return name; } 
            private set 
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Invalid name");
                }
            } 
        }

        public Employee(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public bool IsAdult()
        {
            if (this.Age >= 18)
            {
                return true;
            }
            return false;
        }
        void IPerson.ToString()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}, IsAdult: {(this.IsAdult() ? "yes" : "no")}");
        }
    }
}
