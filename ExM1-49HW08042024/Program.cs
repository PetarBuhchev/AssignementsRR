using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExM1_49HW08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha M1-49
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxNegNum = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNegNum && arr[i] < 0)
                {
                    maxNegNum = arr[i];
                }
            }

            Console.WriteLine("Indexes: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == maxNegNum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
