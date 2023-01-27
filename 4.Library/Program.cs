using _4.Library;

try
{
    Book book = new Book();
    book.Title = "Hello World in C#";
    book.Author = "Pesho";
    book.Price = 2;
    book.Pages = 20;
    Console.WriteLine(book);
    Console.WriteLine();

    Book book1 = new Book("C# in a nutshell", "Gosho", 1200, 70);
    Console.WriteLine(book1);
    Console.WriteLine();

    Book book2 = new Book();
    book2.Author = "";
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}