namespace LoopFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    even++;
                }
                else odd++;
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }
    }
}