using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Square : Shape
    {
        public Square(double side) : base(side)
        {
        }

        public override double CalculateArea()
        {
            return Math.Pow(this.side, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.side;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("The shape is square.");
        }
    }
}
