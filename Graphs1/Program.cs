using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //върхове
            int n = int.Parse(Console.ReadLine());
            //ребра
            int m = int.Parse(Console.ReadLine());

            List<int>[] gr = new List<int>[n+1];

            for (int i = 1; i <= n; i++)
            {
                gr[i] = new List<int>();
            }

            for (int i = 1; i <= n; i++)
            {
                char[] delimeters = { ' ', ':', ',' };

                int[] input = Console.ReadLine()
                    .Split(delimeters, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int node1 = input[0];

                for (int j = 1; j < input.Length; j++)
                {
                    int node2 = input[j];
                    gr[node1].Add(node2);
                }
            }

            //Въвеждане на върхове
            int[] edgesCheck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool check = true;

            for (int i = 0; i < edgesCheck.Length-1; i++)
            {
                if (!gr[edgesCheck[i]].Contains(edgesCheck[i+1]))
                {
                    check = false;
                }
            }

            Console.WriteLine(check);
        }
    }
}
