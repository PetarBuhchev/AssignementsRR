using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal abstract class Shape
    {
        Random r = new Random();
        public int ID;
        public double side;
        private protected Shape(double side)
        {
            this.ID = r.Next(0, 101);
            this.side = side;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public virtual void Print()
        {
            Console.WriteLine(this.side);
            Console.WriteLine(this.CalculateArea());
            Console.WriteLine(this.CalculatePerimeter());
        }
    }
}
