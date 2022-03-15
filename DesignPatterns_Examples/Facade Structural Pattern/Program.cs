using System;
using Facade2.Client_Class;
using Facade2.Facade_Classes;

/* Facade test again. This time I'll make a Client class about books, just so
 * I won't rehash the same topic about cars. Same principles: Client Class 'Books'
 * followed by a Facade class with two different Builder classes. The Facade class
 * will keep a reference to the Builder Classes. In Main, we will create a Book obj
 * through the Facade Class, which, in turn, will reference the Builder classes' methods. */

namespace Facade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new BookFacade()
                .ContentInfo
                    .TitleInfo("The Place of Dead Roads")
                    .AuthorInfo("William Burroughs")
                    .PagesInfo(271)
                    .GenreInfo("Western")
                .PublicationInfo
                    .PublicationCompanyInfo("Fourth Estate")
                    .EditionYearInfo(2010)
                    .OgYearInfo(1983)
                .Build();

            Console.WriteLine(book);

            Console.ReadKey();
        }
    }
}
