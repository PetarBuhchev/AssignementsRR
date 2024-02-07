using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1p115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ITriangle[] triangles = new ITriangle[n];

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                if (input == '1')
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Triangle1 t1 = new Triangle1(a,b,c);
                    triangles[i] = t1;
                }
                else
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double angle = double.Parse(Console.ReadLine());
                    triangles[i] = new Triangle2(a,b,angle);
                }
            }
            foreach (var triangle in triangles) 
            {
                Console.WriteLine(triangle.ToString());
            }
        }
    }
}
