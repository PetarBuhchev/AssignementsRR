﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqvane
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public virtual string GetFullName()
        {
            return $"{this.FirstName}, {this.LastName}";
        }

    }
}
