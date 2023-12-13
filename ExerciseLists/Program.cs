namespace ExerciseLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                myList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Chetni");
            for (int i = 0; i < myList.Count; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(myList[i]);
                }
            }
            Console.WriteLine("Nechetni");
            for (int i = 0; i < myList.Count; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(myList[i]);
                }
            }
        }
    }
}