using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.HW08._03._2024
{
    internal class Program
    {
        static double SumIt(int x, int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += 1 / Math.Pow(x, i);
            }
            return sum;
        }
        static double SumRec(int x, int n)
        {
            if (n == 0) return 1;
            return SumRec(x, n - 1) + 1/ Math.Pow(x,n);
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(SumIt(x,n));
            Console.WriteLine(SumRec(x,n));
        }
    }
}
