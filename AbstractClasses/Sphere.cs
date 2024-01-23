using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Sphere : Shape
    {
        public Sphere(double side) : base(side)
        {
        }

        public override double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(this.side, 2);
        }

        public override double CalculatePerimeter()
        {
            return 0;
        }
    }
}
