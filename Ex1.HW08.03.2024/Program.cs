using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.HW08._03._2024
{
    internal class Program
    {
        static int SumIt(int n, int x)
        {
            int sum = 1;
            for (int i = 2; i <= n; i++)
            {
                sum += (int)Math.Pow(x, i);
            }
            return sum;
        }
        static int SumRec(int n, int x)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return SumRec(n - 1, x) + (int)Math.Pow(x, n);
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(SumIt(n,x));
            Console.WriteLine(SumRec(n,x));
        }
    }
}
