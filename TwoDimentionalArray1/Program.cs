using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimentionalArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());
            int numCols = int.Parse(Console.ReadLine());

            int[,] arr = new int[numRows, numCols];
            for (int rows = 0; rows < numRows; rows++)
            {
                for (int cols = 0; cols < numCols; cols++)
                {
                    int num = int.Parse(Console.ReadLine());
                    arr[rows, cols] = num;
                }
            }

            //Извеждане на елеметните над главния диагонал
            for (int rows = 0; rows < numRows - 1; rows++)
            {
                Console.Write(new string(' ', 2 * rows));
                for (int cols = rows + 1; cols < numCols; cols++)
                {
                    Console.Write(arr[rows, cols] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Извеждане на елементите под обратния диагонал
            for (int rows = 1; rows < numRows; rows++)
            {
                Console.Write(new string(' ', 2 * (numRows - rows-1)));
                for (int cols = numRows-rows; cols < numRows; cols++)
                {
                    Console.Write(arr[rows, cols] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Извеждане на произведението на елементите от обратния диагонал
            int mult = 1;
            for (int i = 0; i < numRows; i++)
            {
                mult *= arr[i, numRows - i - 1];
            }
            Console.WriteLine(mult);
            Console.WriteLine();

            //Извеждане средно-аритметично на елементите над обратния диагонал
            int sum = 0;
            int count = 0;
            for (int rows = 0; rows < numRows-1; rows++)
            {
                for (int cols = 0; cols < numCols-1-rows; cols++)
                {
                    int num = arr[rows, cols];
                    sum += arr[rows, cols];
                    count++;
                }
            }
            double avrg = (double)sum / count;
            Console.WriteLine(avrg);
        }
    }
}
