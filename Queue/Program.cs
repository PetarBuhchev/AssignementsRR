using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "1":
                        string name = Console.ReadLine();
                        queue.Enqueue(name);
                        break;
                    case "2":
                        Console.WriteLine(queue.Peek());
                        queue.Dequeue();
                        break;
                    case "3":
                        Console.WriteLine(queue.Peek());
                        break;
                    default:
                        return;
                }

                Console.WriteLine(string.Join(", ", queue));

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
