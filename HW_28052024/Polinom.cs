using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_28052024
{
    internal class Polinom
    {
        private int n;
        private double[] coefficients;
        public Polinom(int n)
        {
            this.n = n;
            this.coefficients = new double[n + 1];
        }
        public void InputCoefficients()
        {
            for (int i = 0; i < coefficients.Length; i++)
            {
                Console.WriteLine($"Enter a coefficient {i}: ");
                this.coefficients[i] = double.Parse(Console.ReadLine());
            }
        }
        public int GetCoefficientsLength()
        {
            return this.coefficients.Length;
        }
        public double CalculateIt(double x)
        {
            double res = 0;
            for (int i = coefficients.Length-1, j = n; i >= 0; i--, j--)
            {
                if (i == coefficients.Length-1)
                {
                    res += Math.Pow(coefficients[i],j);
                }
                else if (i == 0)
                {
                    res += 1;
                }
                res *= Math.Pow(coefficients[i],j) + x; 
            }
            return res;
        }
        public double CalculateRec(double x, int n, int index)
        {
            if (index < 0)
            {
                return 0;
            }
            else if (index == 0)
            {
                return 1 + CalculateRec(x, n - 1, index - 1);
            }
            else if (index == coefficients.Length-1)
            {
                return Math.Pow(coefficients[index], n) + CalculateRec(x, n - 1, index - 1);
            }
            return (Math.Pow(coefficients[index], n) + x) * CalculateRec(x, n - 1, index - 1);
        }

    }
}
