using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW30052024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            int[] grades = new int[5];
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 1)
                {
                    grades[index++] = int.Parse(list[i].ToString());
                }
            }

            Array.Sort(grades);

            int outputIndex = 0;
            if (grades[3] == grades[4])
            {
                outputIndex = list.LastIndexOf(grades[4].ToString()) - 1;
            }
            else
            {
                outputIndex = list.IndexOf(grades[4].ToString()) - 1;
            }

            Console.WriteLine(list[outputIndex].ToString() + " " + list[outputIndex+1].ToString());
        }
    }
}
