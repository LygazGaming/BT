using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("J.K. Rowling", "longa4609@gmail.com", 'F');
            Book book = new Book("Harry Potter and the Philosopher's Stone",author,10.00,100);
            Console.WriteLine(author.ToString());
            Console.WriteLine(book.ToString());
        }
    }
}
