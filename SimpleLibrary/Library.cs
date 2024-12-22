using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class Library
    {
        private string libraryName;
        private int bookEntered;
        private int bookCount = 0;

        public Library(string name ,int maxBooks) { 
            libraryName = name;
            bookEntered = maxBooks;
            Console.WriteLine($"Library Name: {libraryName} is created");
        }

        public string LibaryName
        {
            get { return libraryName; }
            set { libraryName = value; }
        }

        public void AddBook(string bookTitle)
        {
            if (bookEntered > 0)
            {
                bookCount++;
                Console.WriteLine($"Book '{bookTitle}' added to the library");
                bookEntered--;
            }
            else
            {
                Console.WriteLine("Library is full. Can not add more books");
            }
        }

        public void DisplayBook() {
            Console.WriteLine($"Books available in the {libraryName} are:  {bookCount}");
        }

        ~Library() { 
            Console.WriteLine($"Library {libraryName} object is being destroyed");
        }
    }
}
