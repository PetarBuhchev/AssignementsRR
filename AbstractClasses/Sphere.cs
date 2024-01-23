using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            return 2 * Math.PI * this.side;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("This shape is shpere.");
        }
    }
}
