﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _21._Book_Library_Modification
{
    class BookLibraryModification
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public double Price { get; set; }

            public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, double price)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                ReleaseDate = releaseDate;
                ISBN = isbn;
                Price = price;
            }
        }

        class Library
        {
            public List<Book> Books { get; set; }

            public string Name { get; set; }

            public Library()
            {
                this.Books = new List<Book>();
            }

            public void Add(Book book)
            {
                this.Books.Add(book);
            }
        }

        static void Main(string[] args)
        {
            Library library = new Library();

            AddBooksToLibrary(library);

            DateTime targetDate = DateTime.ParseExact(Console.ReadLine(),
                                                     "dd.MM.yyyy",
                                                     CultureInfo.InvariantCulture);

            foreach (var book in library.Books
                                .Where(b => b.ReleaseDate > targetDate)
                                .OrderBy(b => b.ReleaseDate)
                                .ThenBy(b => b.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }

        }

        private static void AddBooksToLibrary(Library library)
        {
            int numberBooks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberBooks; i++)
            {
                string[] input = Console.ReadLine().Split();

                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], 
                                                    "dd.MM.yyyy",
                                                    CultureInfo.InvariantCulture);
                string isbn = input[4];
                double price = double.Parse(input[5]);

                Book currentBook = new Book(title, author, publisher, releaseDate, isbn, price);

                library.Add(currentBook);
            }
        }
    }
}
