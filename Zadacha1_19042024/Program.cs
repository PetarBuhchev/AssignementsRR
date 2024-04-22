using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1_19042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedInput = new string(input.Reverse().ToArray());

            /*for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }*/

            if (input == reversedInput)
            {
                Console.WriteLine("It is palindrom.");
            }
            else
            {
                Console.WriteLine("It isnt palindrom.");
            }
        }
    }
}
