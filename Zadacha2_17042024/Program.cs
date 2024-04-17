using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_17042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char s = char.Parse(Console.ReadLine());
            int count = input.Count(x => x == s);
            if (count == 0)
            {
                Console.WriteLine("Няма такъв символ във въведения текст!");
                return;
            }
            int[] arr = new int[count];

            int index = 0;
            int arrIndex = 0;
            while (index != -1) 
            {
                arr[arrIndex] = index;
                arrIndex++;
                index = input.IndexOf(s, index+1);
            }

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
