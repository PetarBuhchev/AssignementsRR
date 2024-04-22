using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3_19042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                string edited = char.ToLower(arr[i][0]) + arr[i].Substring(1).ToUpper();
                arr[i] = edited;
            }

            Console.WriteLine(string.Join(",", arr));
        }
    }
}
