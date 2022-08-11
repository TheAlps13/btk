using System;
using System.Collections.Generic;
using System.Linq;

namespace memento_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();
            Book book = new Book("Adventures of the lone turtle", "Alper T.", "This book is about weirdly amazing adventures of a turtle");

            // Saving current state
            careTaker.State = book.SaveState();

            Console.WriteLine(book.ToString());
            Console.ReadLine();

            // Changing book details
            book.Title = "What is love ?";
            book.Author = "Jim C.";
            book.Description = "All the things you need to know about the love"; 

            Console.WriteLine(book.ToString());
            Console.ReadLine();

            // Restoring to previous state
            book.RestoreState(careTaker.State);

            Console.WriteLine(book.ToString());
        }
    }

    public class Book
    {
        private string _title;
        private string _author;
        private string _description;
        private DateTime _lastModified;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                UpdateLastModified();
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                UpdateLastModified();
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                UpdateLastModified();
            }
        }
        public DateTime LastModified
        {
            get
            {
                return _lastModified;
            }
        }

        public Book(string title, string author, string description)
        {

            Title = title;
            Author = author;
            Description = description;
            _lastModified = DateTime.Now;
        }

        public void UpdateLastModified()
        {
            _lastModified = DateTime.Now;
        }

        public BookMemento SaveState()
        {
            return new BookMemento
            {
                Title = Title,
                Author = Author,
                Description = Description,
                LastModified = LastModified
            };
        }

        public void RestoreState(BookMemento state)
        {
            _title = state.Title;
            _author = state.Author;
            _description = state.Description;
            _lastModified = state.LastModified;
        }

        public override string ToString()
        {
            return new string($"Title: {_title}\nAuthor: {_author}\nDescription: {_description}\nLast Modified: {_lastModified}");
        }
    }

    public class BookMemento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime LastModified { get; set; }
    }

    public class CareTaker
    {
        public BookMemento State { get; set; }
    }
}