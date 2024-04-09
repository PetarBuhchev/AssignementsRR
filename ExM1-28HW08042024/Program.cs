using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExM1_28HW08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadacha M1-28
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxValue = arr.Max();
            int index = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == maxValue)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
