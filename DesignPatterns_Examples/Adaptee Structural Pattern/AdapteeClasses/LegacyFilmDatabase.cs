using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.AdapteeClasses
{
    // The 'Adaptee' Class
    public class LegacyFilmDatabase 
    {
        public int GetYear(string movie)
        {
            switch(movie?.ToLower())
            {
                case "hard to be a god": return 2013;
                case "sonatine": return 1993;
                case "tetsuo: the iron man": return 1989;
                default: return 0;
            }
        }

        public string GetDirector(string movie)
        {
            switch (movie?.ToLower())
            {
                case "hard to be a god": return "Aleksei German";
                case "sonatine": return "Takeshi Kitano";
                case "tetsuo: the iron man": return "Shinya Tsukamoto";
                default: return null;
            }
        }

        public string GetGenre(string movie)
        {
            switch (movie?.ToLower())
            {
                case "hard to be a god": return "Medieval/Arthouse";
                case "sonatine": return "Crime/Drama";
                case "tetsuo: the iron man": return "Horror/Arthouse";
                default: return null;
            }
        }
    }
}
