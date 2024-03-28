using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Demo2503202401
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
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 1)
                {
                    arr2[i] = arr[i];
                }
            }

            for (int i = arr2.Length-1; i >= 0; i--)
            {
                if (arr2[i] != 0)
                {
                    Console.WriteLine(arr2[i]);
                }
            }
            Array.Re    
        }
    }
}
