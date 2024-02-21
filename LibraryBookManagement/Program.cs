// See https://aka.ms/new-console-template for more information

using System;

namespace LibraryManagement
{
    class Book
    {
        public string Title;
        public string author;
        public string year;

        public Book(string Title, string author, string year)
        {
            this.Title = Title;
            this.author = author;
            this.year = year;
        }
        
        public void DisplayDetails()
        {
            Console.WriteLine($"Title {Title}, Author {author}, Year {year}");
        }
    }

    class Library
    {
        List<Book> books;
        
        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book b)
        {
            books.Add(b);
        }

        public void DisplayLibraryDetails()
        {
            foreach(var b in books)
            {
                b.DisplayDetails();
                Console.WriteLine("------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library l = new Library();

            Book b = new Book("leadership Secrets", "Maxwell", "2022");
            Book b1 = new Book("Think and Grow Rich","Lewis","2022");

            l.AddBook(b);
            l.AddBook(b1);

            l.DisplayLibraryDetails();
        }
    }
}
