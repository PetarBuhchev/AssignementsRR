using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_19042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string edited = char.ToUpper(input[0]) + input.Substring(1).ToLower();
            Console.WriteLine(edited);
        }
    }
}
