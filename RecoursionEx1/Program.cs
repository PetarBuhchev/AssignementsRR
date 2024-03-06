using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoursionEx1
{
    internal class Program
    {
        static int NODiterative(int a, int b)
        {
            int r;
            if (b < a)
            {
                while (b != 0)
                {
                    r = a % b;
                    a = b; b = r;
                }
                return a;
            }
            else
            {
                while (a != 0)
                {
                    r = b % a;
                    b = a; a = r;
                }
                return b;
            }
        }
        static int NODrecoursive(int a, int b)
        {
            if (b == 0) return a;
            return NODrecoursive(b, a % b);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
        }
    }
}
