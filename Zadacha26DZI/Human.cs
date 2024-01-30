using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_26
{
    internal class Human
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int age;

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        
        public override string ToString() 
        {
            return $"{this.firstName} {this.lastName}, {this.age} years old";
        }
    }
}
