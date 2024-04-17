using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._17042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            int count1 = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z' || input[i] >= 'a' && input[i] <= 'z')
                {
                    count += input[i];
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    count1 += input[i];
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(count1);
        }
    }
}
