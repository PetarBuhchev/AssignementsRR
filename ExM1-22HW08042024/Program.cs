using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExM1_22HW08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha M1-22
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
