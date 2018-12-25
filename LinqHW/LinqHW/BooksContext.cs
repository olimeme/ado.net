namespace LinqHW
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BooksContext : DbContext
    {
        public BooksContext()
            : base("name=BooksContext")
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public void SearchAutor(string name)
        {
            using (var context = new BooksContext())
            {
                var autors = Authors.Where(autor => autor.Name.Contains(name));

                int count = 1;

                if (autors.Count() == 0)
                    Console.WriteLine("ничего не найдено!");
                else
                    foreach (var autor in autors)
                        Console.WriteLine(count + ") " + autor.Name);
            }
        }

        public void SearchBook(string name)
        {
            using (var context = new BooksContext())
            {
                var books = context.Books.Where(book => book.Name.Contains(name));

                int count = 1;

                if (books.Count() == 0)
                    Console.WriteLine("ничего не найдено!");
                else
                    foreach (var book in books)
                        Console.WriteLine(count + ") " + book.Name);
            }
        }

        public void SelectAllBooks()
        {
            using (var context = new BooksContext())
            {
                var books = context.Books.Select(book => book);

                int count = 1;

                if (books.Count() == 0)
                    Console.WriteLine("Ничего не найдено!");
                else
                    foreach (var book in books)
                    {
                        Console.WriteLine(count + ") " + book.Name);
                        count++;
                    }
            }
        }

        public void SelectAllAuthor()
        {
            using (var context = new BooksContext())
            {
                var authors = context.Authors.Select(author => author);

                int count = 1;

                if (authors.Count() == 0)
                    Console.WriteLine("Ничего не найдено!");
                else
                    foreach (var author in authors)
                    {
                        Console.WriteLine(count + ") " + author.Name);
                        count++;
                    }
            }
        }

        public void SelectBookById(int id)
        {
            using (var context = new BooksContext())
            {
                var book = Books.FirstOrDefault(bookId => bookId.Id == id);

                if (book != null)
                {
                    Console.WriteLine("Имя: " + book.Name);
                    Console.WriteLine("Автор: " + book.Author);
                }
                else
                    Console.WriteLine("Ничего не найдено!");
            }
        }

        public void SelectAuthorById(int id)
        {
            using (var context = new BooksContext())
            {
                var author = Authors.FirstOrDefault(authorId => authorId.Id == id);

                if (author!= null)
                    Console.WriteLine("Имя: " + author.Name);
                else
                    Console.WriteLine("Ничего не найдено!");
            }
        }
    }
}