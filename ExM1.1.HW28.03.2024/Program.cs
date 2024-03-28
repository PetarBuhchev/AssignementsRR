using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExM1._1.HW28._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Zadacha M1-1
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == b)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
