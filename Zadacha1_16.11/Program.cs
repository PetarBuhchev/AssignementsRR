namespace Zadacha1_16._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
        static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                    string spaces = new string(' ', (n - i) * 2);
                    Console.Write(spaces);
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}