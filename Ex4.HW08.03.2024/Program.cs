using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4.HW08._03._2024
{
    internal class Program
    {
        static int BinomIt(int n, int k)
        {
            int num = 1;
            for (int i = n; i >= 1; i--)
            {
                num *= i;
            }
            int denum = 1;
            for (int k1 = k; k1 >= 1; k1--)
            {
                denum *= k1;
            }
            for (int k2 = n-k; k2 >= 1; k2--)
            {
                denum *= k2;
            }
            int result = num / denum;
            return result;
        }
        static int BinomRec(int n, int k)
        {
            if (k == 0 || k == n) return 1;
            return BinomRec(n - 1, k) + BinomRec(n - 1, k - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(BinomIt(n,k));
            Console.WriteLine(BinomRec(n,k));
        }
    }
}
