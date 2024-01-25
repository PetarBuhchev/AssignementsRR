using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();
            IPerson e1 = new Employee("Ivan", 20);
            IPerson e2 = new Employee("Asen", 16);

            IPerson m1 = new Manager("Ana", 30, "Administration");
            IPerson m2 = new Manager("Maria", 25, "HR");

            people.Add(e1);
            people.Add(e2);
            people.Add(m1);
            people.Add(m2);

            foreach (IPerson person in people) 
            {
                person.ToString();
            }
        }
    }
}
