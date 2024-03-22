using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1HW._19._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                ints[i] = num;
            }

            for (int i = ints.Length-1; i >= 0 ; i--) 
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}
