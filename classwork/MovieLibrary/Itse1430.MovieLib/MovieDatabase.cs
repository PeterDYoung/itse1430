using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>Manages the movies in a database.</summary>
    public class MovieDatabase
    {
        public void Add ( Movie movie )
        {
            _movies.Add (movie);
            ////Add to array
            //for (var index = 0; index < _movies.Count; ++index)
            //{
            //    if (_movies[index] == null)
            //    {
            //        _movies[index] = movie;
            //        return;
            //    };
            //};
        }

        public void Remove ( Movie movie )
        {
            _movies.Remove (movie);
            ////Remove from array
            //for (var index = 0; index < _movies.Count; ++index)
            //{
            //    //This won't work
            //    if (_movies[index] == movie)
            //    {
            //        _movies[index] = null;
            //        return;
            //    };
            //};
        }

        public Movie[] GetAll ()
        {
            ////Filter out empty movies
            //var count = 0;
            //foreach (var movie in _movies)
            //    if (movie != null)
            //        ++count;

            var index = 0;
            var movies = new Movie[_movies.Count];
            foreach (var movie in _movies)
                if (movie != null)
                    movies[index++] = movie;

            return movies;
        }


        //private Movie[] _movies = new Movie[100];
        //Dynamically resizing array
        private List<Movie> _movies = new List<Movie> ();

        //Identical to List<T>, just wrong namespace
        // using System.Collections.ObjectModel;
        //private Collection<Movie> _movies = new Collection<Movie>();

    }
}

