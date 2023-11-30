namespace LoopWithCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            while (input >= 0)
            {
                if (input % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }
    }
}