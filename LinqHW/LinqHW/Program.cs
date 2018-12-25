using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW
{
    class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Вывести всех авторов");
            Console.WriteLine("2. Вывести все книги");
            Console.WriteLine("3. Найти книгу");
            Console.WriteLine("4. Найти автора");
            Console.WriteLine("5. Найти книгу по индексу");
            Console.WriteLine("6. Найти автора по индексу");
            Console.WriteLine("7. Выход");
        }

        public static bool Select(char select,BooksContext context)
        {
            switch(select)
            {
                case '1':
                    context.SelectAllAuthor();
                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    return false;
                case '2':
                    context.SelectAllBooks();
                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    return false;
                case '3':
                    Console.WriteLine("Введите имя автора: ");
                    var nameAutor = Console.ReadLine();

                    context.SearchAutor(nameAutor);

                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    return false;
                case '4':
                    Console.WriteLine("Введите имя книги: ");
                    var nameBook = Console.ReadLine();

                    context.SearchBook(nameBook);

                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    return false;
                case '5':
                    Console.WriteLine("Введите индекс книги: ");
                    nameBook = Console.ReadLine();

                    int number;
                    if (int.TryParse(nameBook, out number))
                        context.SelectBookById(number);

                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    return false;
                case '6':
                    Console.WriteLine("Введите индекс автора: ");
                    nameBook = Console.ReadLine();

                    if (int.TryParse(nameBook, out number))
                        context.SelectAuthorById(number);

                    Console.WriteLine("Нажмите любую кнопку...");
                    Console.ReadKey();
                    return false;
                case '7':
                    return true;
                default:
                    return false;
            }
        }

        static void Main(string[] args)
        {
            using (var context = new BooksContext())
            {
                var authorOne = new Author
                {
                    Name = "Олег"
                };

                var authorTwo = new Author
                {
                    Name = "Олег2"
                };

                var bookOne = new Book
                {
                    Name = "Homo Sapians",
                    Author = authorOne
                };

                var bookTwo = new Book
                {
                    Name = "Art of not giving a fuck",
                    Author = authorTwo
                };

                context.Authors.Add(authorOne);
                context.Authors.Add(authorTwo);
                context.Books.Add(bookOne);
                context.Books.Add(bookTwo);
                context.SaveChanges();
                bool check = false;
                while(!check)
                {
                    PrintMenu();
                    char select = Console.ReadKey().KeyChar;
                    Console.Clear();
                    check = Select(select, context);
                    Console.Clear();
                }
            } 
        }
    }
}
