using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_24042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', '.', ' ' };
            string[] arr1 = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(arr1);
            Array.Sort(arr2);
            string[] arr3 = new string[arr1.Length + arr2.Length];

            int numArr1 = 0, numArr2 = 0, numArr3 = 0;

            while (numArr1 < arr1.Length && numArr2 < arr2.Length)
            {
                if (arr1[numArr1].CompareTo(arr2[numArr2]) < 0)
                {
                    arr3[numArr3++] = arr1[numArr1++];
                }
                else
                {
                    arr3[numArr3++] = arr2[numArr2++];
                }
            }
            while (numArr1 < arr1.Length)
            {
                arr3[numArr3++] = arr1[numArr1++];
            }
            while (numArr2 < arr2.Length)
            {
                arr3[numArr3++] = arr2[numArr2++];
            }

            Console.WriteLine(string.Join(", ", arr3));
        }
    }
}
