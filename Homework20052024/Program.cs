using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20052024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] colsNRows = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            int rows = colsNRows[0];
            int cols = colsNRows[1];

            if (elements.Length != rows * cols)
            {
                return;
            }

            int currentRow = 0;
            int currentCol = 0;
            int indexArr = 0;

            int[,] arr = new int[rows, cols];

            while (indexArr < elements.Length)
            {
                if (currentCol == cols)
                {
                    currentCol = 0;
                    currentRow++;
                }

                if (currentRow == rows)
                {
                    break;
                }
                arr[currentRow, currentCol++] = elements[indexArr++];
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }

            int count = 0;

            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    int num1 = arr[row, col];
                    int num2 = arr[row - 1, col];
                    int num3 = arr[row - 1, col - 1];
                    int num4 = arr[row, col - 1];

                    if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0 && num4 % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Броят четворки от четни числа е {count}.");
        }
    }
}
