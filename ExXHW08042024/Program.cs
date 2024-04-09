using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExXHW08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha 3ta ot sortirane
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }
    }
}
