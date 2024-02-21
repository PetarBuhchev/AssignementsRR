using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormatException fe = new FormatException("The number is negative!");
			double v = double.Parse(Console.ReadLine());
			double t = double.Parse(Console.ReadLine());

            if (v < 0 || t < 0)
            {
                throw fe;
            }
            else
            {
                Console.WriteLine(v*t);
            }
        }
    }
}
