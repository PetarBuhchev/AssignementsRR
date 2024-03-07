using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumsDividedBy3and4
{
    internal class Program
    {
        static int CountIt(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int CountRec(int n)
        {
            if (n == 1) return 0;
            return CountRec(n - 1) + ((n % 3 == 0) || (n % 4 == 0) ? 1 : 0);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CountIt(n));
            Console.WriteLine(CountRec(n));
        }
    }
}
