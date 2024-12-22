using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Library Name: ");
            string libraryName = Console.ReadLine();

            Console.WriteLine("Enter max number of books on the library");
            int maxBooks = int.Parse(Console.ReadLine());

            Library myLib = new Library(libraryName, maxBooks);

            Console.WriteLine("\nEnter book title:");

            do
            {
                string input = Console.ReadLine();
                myLib.AddBook(input);
                maxBooks--;

            }while(maxBooks >= 0);
            myLib.DisplayBook();
        }
    }
}
