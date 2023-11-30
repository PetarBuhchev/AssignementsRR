namespace ConditionalStatementsZadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 6) 
            {
                Console.WriteLine("Дете");
            }
            else if (age > 6 && age < 18)
            {
                Console.WriteLine("ученик");
            }
            else if (age > 18 && age < 25)
            {
                Console.WriteLine("студент");
            }
            else if (age > 25 && age < 65)
            {
                Console.WriteLine("работещ");
            }
            else
            {
                Console.WriteLine("пенсионер");
            }
        }
    }
}