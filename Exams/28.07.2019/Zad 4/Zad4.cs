namespace Zad4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Zad4
    {
        class Library
        {
            public Library(string name, string town)
            {
                this.Name = name;
                this.Town = town;
                this.Books = new List<Book>();
            }
            public string Name { get; set; }
            public string Town { get; set; }

            public List<Book> Books { get; set; }
        }

        class Book
        {
            public Book(string name)
            {
                this.Name = name;
            }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            List<Library> libraries = new List<Library>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                string[] inputLine = input.Split(':');

                string command = inputLine[0];

                if (command == "Library")
                {
                    string libraryName = inputLine[1];
                    string townName = inputLine[2];

                    Library library = new Library(libraryName, townName);

                    if (libraries.All(l => l.Name != libraryName))
                    {
                        libraries.Add(library);
                    }
                }
                else if (command == "Book")
                {
                    string bookName = inputLine[1];
                    string libraryName = inputLine[2];

                    if (libraries.All(l => l.Name != libraryName))
                    {
                        Console.WriteLine($"Library {libraryName} does not exist!");
                    }
                    else
                    {
                        Book book = new Book(bookName);

                        libraries.First(l => l.Name == libraryName).Books.Add(book);
                    }
                }
            }

            foreach (var library in libraries)
            {
                Console.WriteLine($"Library {library.Name}, based in {library.Town}:");

                Console.WriteLine(string.Join(", ", library.Books.Select(b=>b.Name)));
            }
        }
    }
}
