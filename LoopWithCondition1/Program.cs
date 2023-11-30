namespace LoopWithCondition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int bigNeg = int.MinValue;
            int smallPoss = int.MaxValue;
            while (input != 0) 
            {
                if (input < 0)
                {
                    if (input > bigNeg)
                    {
                        bigNeg = input;
                    }
                }
                else
                {
                    if (input < smallPoss)
                    {
                        smallPoss = input;
                    }
                }
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(bigNeg);
            Console.WriteLine(smallPoss);
        }
    }
}