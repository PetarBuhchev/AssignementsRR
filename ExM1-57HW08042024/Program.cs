using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExM1_57HW08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha M1-57
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] negArr = new int[arr.Length];
            int[] posArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    posArr[i] = arr[i];
                }
                else if (arr[i] < 0)
                {
                    negArr[i] = arr[i];
                }
            }
        }
    }
}
