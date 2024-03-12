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
        }
    }
}
