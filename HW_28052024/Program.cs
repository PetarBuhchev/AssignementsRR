using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_28052024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Polinom polinom = new Polinom(n);
            polinom.InputCoefficients();
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Step: ");
            double step = double.Parse(Console.ReadLine());

            for (double x = x1; x <= x2; x += step)
            {
                Console.WriteLine($"x = {x}\t\t{polinom.CalculateIt(x)}\t\t {polinom.CalculateRec(x, n, polinom.GetCoefficientsLength())}");
            }
        }
    }
}
