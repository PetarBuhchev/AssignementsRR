namespace Exercise3011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("John", "Software Engineer", 3500, 5);
            Employee e2 = new Employee("Mark", "Shop assistant", 1000, 1);
            Employee e3 = new Employee("Ivan", "DevOp", 15000, 6);

            Office office1 = new Office("CorpoX", e1, e2);
            Console.WriteLine(office1.MaxSalary());

            Office office2 = new Office("CorpoX2", e1, e2);
            office1.ChangeEmployee(ref office1.employee1, e3);
            office1.Print();
            Console.WriteLine();
            office2.Print();
        }
    }
}