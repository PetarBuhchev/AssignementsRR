﻿namespace ConditionalStatementsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else { Console.WriteLine("Ms."); }
            }
            else
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else { Console.WriteLine("Mr."); }
            }
        }
    }
}