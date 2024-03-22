using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.HW22._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            double max = double.MinValue;
            double min = double.MaxValue;

            foreach (double d in arr) 
            {
                if (d > max && d % 2 == 0)
                {
                    max = d;
                }
                if (d < min && d % 2 == 1)
                {
                    min = d;
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
