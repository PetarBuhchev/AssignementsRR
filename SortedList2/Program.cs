using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, List<string>> sl = new SortedList<string, List<string>>();

            string country = Console.ReadLine();

            while (country != "end")
            {
                sl.Add(country, Console.ReadLine().Split().ToList());
                country = Console.ReadLine();
            }

            foreach (var item in sl)
            {
                if (item.Key.Length > 6)
                {
                    Console.Write(item.Key + " - ");
                    foreach (var item2 in item.Value) 
                    {
                        Console.Write(item2 + " ");
                    }
                Console.WriteLine();
                }
            }
        }
    }
}
