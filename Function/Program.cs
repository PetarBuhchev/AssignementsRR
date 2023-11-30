namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Length(a, b);

            Console.WriteLine(Length(a,b));
            Console.WriteLine(Area(a,b));
            Console.WriteLine(Perimeter(a,b,c));
        }
        static double Length(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }
        static double Area(double a, double b)
        {
            double area = (a * b) / 2.0;
            return area;
        }
        static double Perimeter(double a, double b, double c)
        {
            double p = a + b + c;
            return p;
        }
    }
}