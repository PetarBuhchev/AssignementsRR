using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.HW22._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 1)
                {
                    arr2[i] = num;
                }
                arr[i] = num;
            }

            arr2 = arr2.OrderByDescending(x => x).ToArray();

            foreach (int i in arr2) 
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
