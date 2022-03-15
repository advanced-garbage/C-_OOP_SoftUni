using System;
using System.Collections.Generic;
using System.Text;
using Facade2.Client_Class;

namespace Facade2.Facade_Classes
{
    public class BookPublicationBuilder : BookFacade
    {
        public BookPublicationBuilder(Book book)
        {
            Book = book;
        }

        public BookPublicationBuilder OgYearInfo(int year)
        {
            Book.OriginalYearOfRelease = year;
            return this;
        }

        public BookPublicationBuilder EditionYearInfo(int year)
        {
            Book.EditionYear = year;
            return this;
        }

        public BookPublicationBuilder PublicationCompanyInfo(string companyName)
        {
            Book.ProductionCompany = companyName;
            return this;
        }
    }
}
