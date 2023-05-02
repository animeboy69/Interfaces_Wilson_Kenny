using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Wilson_Kenny
{
    class Movie : IGenre
    {
        // Tells the name of the movie and the Genre.
        public string Esrb { get; set; }
        public string Genre { get; set; }// Tells what the movie Genre is.
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
        /// <summary>
        /// Tells the user when the movie is starting.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{ Title} is starting Please be quite!");
        }
        /// <summary>
        ///  Tells what the name of the game is and the rating is for that game.
        /// </summary>
        /// <returns></returns>
            public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!"; 

        }
    }
}
