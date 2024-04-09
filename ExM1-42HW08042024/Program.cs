using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExM1_42HW08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha M1-42
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double avrg = arr.Average();
            int count = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > avrg)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
