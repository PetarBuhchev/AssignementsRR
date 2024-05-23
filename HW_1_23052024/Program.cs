using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_23052024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] arr = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = Console.ReadLine();
                }
            }

            string[] output = new string[cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                output[index++] = arr[i, rows - i - 1];
            }

            int max = 0;
            int indexOutput = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i].Length > max)
                {
                    max = output[i].Length;
                    indexOutput = i;
                }
            }

            Console.WriteLine(output[indexOutput]);
        }
    }
}
