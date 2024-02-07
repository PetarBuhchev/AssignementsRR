using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1p115
{
    internal class Triangle1 : ITriangle
    {
        public double a, b, c;

        public Triangle1(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Invalid sides");
            }   
        }

        public double Face()
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimeter()
        {
            return a + b + c;
        }
        public override string ToString() 
        {
            return $"Triangle sides are: {this.a}, {this.b}, {this.c}; its face is {this.Face()} and its perimeter is {this.Perimeter()}";
        }
    }
}
