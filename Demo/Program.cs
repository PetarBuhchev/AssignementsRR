﻿namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 42, count = 0;
            while (n > 1)
            {
                count++;
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = 3 * n + 1;
            }
            Console.WriteLine(count);
        }
    }
}