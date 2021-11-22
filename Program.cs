using System;
using System.IO;

namespace CompositionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());
            Book myBook = new Book("12242", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.GetAuthor().ToString() + "\n\n");
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");            
            Console.WriteLine(yourBook.ToString());
        }
    }
}
