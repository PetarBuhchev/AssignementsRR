using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework26._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            double avrgGrade = 0;
            try
            {
                text = Console.ReadLine();
                avrgGrade = double.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Грешно изписване на среден успех.");
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Файлът не съществува.");
            }
            catch (Exception)
            {
                Console.WriteLine("Грешка");
            }

            using (StreamWriter writer = new StreamWriter("studentFile.txt"))
            {
                writer.Write(text + " ");
                writer.Write(avrgGrade);
            }

            using (StreamReader reader = new StreamReader("studentFile.txt"))
            {

                string textRead = reader.ReadLine();
                int index = textRead.IndexOf(" ");
                string name = (textRead.Substring(0, index)).ToUpper();
                double grade = double.Parse(textRead.Substring(index + 1, textRead.Length - index - 1));
                Console.WriteLine($"{name} {grade:f4}");
            }
        }
    }
}
