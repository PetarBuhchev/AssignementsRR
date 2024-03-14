using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.HW14._03._2024
{
    internal class Program
    {
        static int NumIt(int n)
        {
            int a1 = 2;
            int a2 = 4;
            int a3 = 6;
            int a4 = 0;
            for (int i = 4; i <= n; i++)
            {
                a4 = 3 * a1 + 4 * a2 - 7 * a3;
                a1 = a2; a2 = a3; a3 = a4;
            }
            return a4;
        }
        static int NumRec(int n)
        {
            if (n == 3) return 6;
            else if (n == 2) return 4;
            else if (n == 1) return 2;
            else if (n == 0) return 0;

            return 3 * NumRec(n-3) + 4 * NumRec(n-2) - 7 * NumRec(n-1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(NumIt(n));
            Console.WriteLine(NumRec(n));
        }
    }
}
