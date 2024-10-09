using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command) 
                {
                    case "1":
                        double num = double.Parse(Console.ReadLine());
                        stack.Push(num);
                        break;
                        case "2":
                        Console.WriteLine(stack.Pop());
                        break;
                        case "3":
                        Console.WriteLine(stack.Peek());
                        break;
                        case "4":
                        return;
                }
            }
        }
    }
}
