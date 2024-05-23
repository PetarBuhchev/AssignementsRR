using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_23052024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = int.Parse(Console.ReadLine());
                }
            }

            int min = int.MaxValue;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1 - row; col++)
                {
                    if (arr[row, col] > 0 && arr[row, col] < min)
                    {
                        min = arr[row, col];
                    }
                }
            }

            if (min == int.MaxValue)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(min);
            }
        }
    }
}
