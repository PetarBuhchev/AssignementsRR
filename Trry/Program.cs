using System.Security.Cryptography;

namespace Trry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>
            {
                new Human("John", "Doe", 25),
                new Human("Jane", "Smith", 30),
            new Human("Bob", "Johnson", 22)
        };

            // Display the list of humans
            Console.WriteLine("Original List:");
            DisplayHumans(humans);

            // Order the list by index in descending order
            var orderedList = humans.Select((human, index) => new { Human = human, Index = index })
                                    .OrderByDescending(x => x.Index)
                                    .Select(x => x.Human)
                                    .ToList();

            // Display the ordered list
            Console.WriteLine("\nOrdered List by Index (Descending):");
            DisplayHumans(orderedList);
        }
    }
    }

}