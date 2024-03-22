using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.HW21._03._2024
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

            string[] arr2 = new string[n];
            for (int i = arr2.Count()-1; i >= 0; i--)
            {
                if (i == arr2.Count()-1)
                {
                    arr2[i] = arr[0];
                }
                else
                {
                arr2[i] = arr[i + 1];
                }
            }

            foreach (var text in arr2)
            {
                Console.WriteLine(text);
            }
        }
    }
}
