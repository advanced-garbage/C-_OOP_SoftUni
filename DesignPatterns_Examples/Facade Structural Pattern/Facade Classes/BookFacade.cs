using System;
using System.Collections.Generic;
using System.Text;
using Facade2.Client_Class;

namespace Facade2.Facade_Classes
{
    // The Facade Class
    // There are two references, each for every Builder class
    // The Builder classes, however, have no reference to the Facade Class.
    public class BookFacade
    {
        public BookFacade()
        {
            Book = new Book();
        }
        public Book Book { get; set; }

        public Book Build() => Book;

        public BookContentBuilder ContentInfo => new BookContentBuilder(Book);
        public BookPublicationBuilder PublicationInfo => new BookPublicationBuilder(Book);
    }
}
