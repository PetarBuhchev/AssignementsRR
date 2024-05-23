using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_23052024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (input.Length != rows * cols)
            {
                return;
            }

            int[,] arr = new int[rows, cols];

            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = input[index++];
                }
            }

            int sumAvrgPositive = 0;
            int countPositive = 0;

            int countNegative = 0;

            int sumEvenNum = 0;

            int maxOddNum = int.MinValue;
            for (int row = 1; row < rows; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    if (arr[row, col] > 0)
                    {
                        sumAvrgPositive += arr[row, col];
                        countPositive++;
                    }
                    else if (arr[row, col] < 0)
                    {
                        countNegative++;
                    }

                    if (arr[row, col] % 2 == 0)
                    {
                        sumEvenNum += arr[row, col];
                    }
                    else if (arr[row, col] % 2 == 1 && arr[row, col] > maxOddNum)
                    {
                        maxOddNum = arr[row, col];
                    }
                }
            }
            double avrg = sumAvrgPositive / countPositive * 1.0;
            Console.WriteLine($"avrg: {avrg}");
            Console.WriteLine($"countNegative: {countNegative}");
            Console.WriteLine($"sumEven: {sumEvenNum}");
            Console.WriteLine($"max: {maxOddNum}");
        }
    }
}
