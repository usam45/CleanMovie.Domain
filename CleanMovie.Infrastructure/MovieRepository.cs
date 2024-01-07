using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie {Id =  1, Name ="ABC", Cost = 2},
            new Movie {Id =  1, Name ="DEF", Cost = 4}
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
