using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_29042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i-1])
                {
                    stringBuilder.Append(input[i-1]);
                }
            }
            stringBuilder.Append(input[input.Length - 1]);
            Console.WriteLine(stringBuilder);
        }
    }
}
