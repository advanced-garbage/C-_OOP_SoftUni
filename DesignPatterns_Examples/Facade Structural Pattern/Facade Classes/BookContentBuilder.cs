using System;
using System.Collections.Generic;
using System.Text;
using Facade2.Client_Class;

namespace Facade2.Facade_Classes
{
    public class BookContentBuilder : BookFacade
    {
        public BookContentBuilder(Book book)
        {
            Book = book;
        }

        public BookContentBuilder TitleInfo(string title)
        {
            Book.Title = title;
            return this;
        }

        public BookContentBuilder AuthorInfo(string author)
        {
            Book.Author = author;
            return this;
        }

        public BookContentBuilder PagesInfo(int pages)
        {
            Book.Pages = pages;
            return this;
        }

        public BookContentBuilder GenreInfo(string genre)
        {
            Book.Genre = genre;
            return this;
        }
    }
}
