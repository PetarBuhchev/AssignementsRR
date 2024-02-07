using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1p115
{
    internal class Triangle2 : ITriangle
    {
        public double a, b, c;
        public double angle;

        public Triangle2(double a, double b, double angle)
        {
            if (a > 0 && b > 0 && angle > 0 && angle < 180)
            {
                this.a = a;
                this.b = b;
                this.angle = angle;
            }
            else
            {
                throw new Exception("Invalid side or angle");
            }
        }

        public double Face()
        {
            return (a * b * Math.Sin(angle) / 2);
        }

        public double Perimeter()
        {
            this.c = Math.Sqrt(this.a * this.a + this.b * this.b - 2 * this.a * this.b * Math.Cos(this.angle));
            return a + b + c;
        }
        public override string ToString()
        {
            return $"Triangle sides are: {this.a}, {this.b}, {this.c}; its face is {this.Face()} and its perimeter is {this.Perimeter()}";
        }
    }
}
