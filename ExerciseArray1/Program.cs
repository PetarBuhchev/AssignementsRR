namespace ExerciseArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            Random r = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = r.Next(0, 101);
            }
            for (int i = myArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}