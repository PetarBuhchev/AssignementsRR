using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.HW22._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            if (arr.Count() % 2 == 0)
            {
                for (int i = 0; i < arr.Count()/2; i++)
                {
                    Console.WriteLine(arr[i]);
                    Console.WriteLine(arr[arr.Length - 1 - i]);
                }
            }
            else 
            {
                for (int i = 0; i < arr.Count() / 2; i++)
                {
                    Console.WriteLine(arr[i]);
                    Console.WriteLine(arr[arr.Count() - i - 1]);
                }
                Console.WriteLine(arr[arr.Count() / 2]);
            }
        }
    }
}
