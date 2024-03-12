using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.HW08._03._2024
{
    internal class Program
    {
        static int SumIt(int n)
        {
            int sum = 0;
            for (int i = n; i >= 2; i--)
            {
                sum += i * (i - 1);
            }
            return sum;
        }
        static int SumRec(int n)
        {
            if (n == 0 || n == 1) return 0;
            return SumRec(n - 1) + n * (n-1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(SumIt(n));
            Console.WriteLine(SumRec(n));
        }
    }
}
