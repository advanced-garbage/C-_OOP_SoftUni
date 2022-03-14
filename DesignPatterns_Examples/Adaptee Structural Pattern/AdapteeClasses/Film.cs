using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.AdapteeClasses
{
    // The 'Adapter' class
    public class Film : IFilm
    {
        private string filmName;
        private LegacyFilmDatabase filmDB;

        public Film(string filmName)
        {
            this.filmName = filmName;
            this.filmDB = new LegacyFilmDatabase();
        }

        public override void Display()
        {
            // This method will direct the fields to the Adaptee class
            this.year = filmDB.GetYear(filmName);
            this.genre = filmDB.GetGenre(filmName);
            this.director = filmDB.GetDirector(filmName);
            Console.WriteLine($"Year of release: {this.year}");
            Console.WriteLine($"Director: {this.director}");
            Console.WriteLine($"Genre: {this.genre}");
        }
    }
}
