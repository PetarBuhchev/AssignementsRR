namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Book book1 = new Book();
            book1.title = "Les Miserables";
            book1.Price = decimal.Parse(Console.ReadLine());
            book1.Quantity = int.Parse(Console.ReadLine());
            double total = Book.TotalSum(book1.Price, book1.Quantity);

            Console.WriteLine($"Заглавието на книгата е: {book1.title}");
            Console.WriteLine($"Авторът на книгата е: {book1.Author}");
            Console.WriteLine($"Цената на книгата е: {book1.Price}");
            Console.WriteLine($"Количеството продажби на книгата е: {book1.Quantity}");
            Console.WriteLine($"Тотал от продажби: {total}");
        }
    }
}