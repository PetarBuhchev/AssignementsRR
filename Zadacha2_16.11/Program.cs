namespace Zadacha2_16._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            IntegerToBase(number, toBase);
        }
        static void IntegerToBase(int number, int toBase)
        {
            string output = "";
            while (number > 0) 
            {
                int digit = number % toBase;
                output = digit.ToString() + output;
                number = number / toBase;
            }
            Console.WriteLine(output);
        }
    }
}