using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.HW19._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            string[] newArr = arr.OrderByDescending(x => x).ToArray();

            foreach (string s in newArr) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
