namespace zad_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Human> list = new List<Human>();

            for (int i = 0; i < n; i++)
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Your choise [s-student], [w--worker]:");
                char symbolPickingObject = char.Parse(Console.ReadLine());
                if (symbolPickingObject == 's')
                {
                    double grade = double.Parse(Console.ReadLine());
                    Student s1 = new Student(firstName, lastName, age, grade);
                    list.Add(s1);
                }
                else 
                {
                    double wage = double.Parse(Console.ReadLine());
                    int workingHours = int.Parse(Console.ReadLine());
                    Worker w1 = new Worker(firstName, lastName, age, wage, workingHours);
                    list.Add(w1);
                }
            }

            List<Human> orderedList = list.Select((human, index) => new {Human = human, Index = index })
                .OrderByDescending(x => x.Index)
                .Select(x => x.Human)
                .ToList();

            foreach (Human human in orderedList) 
            {
                Console.WriteLine(human.ToString()); 
                Console.WriteLine();
            }
        }
    }
}