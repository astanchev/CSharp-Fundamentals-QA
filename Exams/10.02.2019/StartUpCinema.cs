using System.Text;

namespace _03.Cinema_10February2019
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public class Cinema
        {
            public Cinema(string cinemaName)
            {
                CinemaName = cinemaName;
                Movies = new List<Movie>();
            }
            public string CinemaName { get; set; }
            public List<Movie> Movies { get; set; }

        }

        public class Movie
        {
            public Movie(string movieName, decimal moviePrice)
            {
                MovieName = movieName;
                MoviePrice = moviePrice;
            }
            public string MovieName { get; set; }
            public decimal MoviePrice { get; set; }
        }

        static void Main(string[] args)
        {
            List<Cinema> cinemas = new List<Cinema>();
            

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                //This is the way to use strings for separator in older versions.
                string[] inputLine = input.Split(new [] {" <=> ", " : "}, StringSplitOptions.RemoveEmptyEntries);

                string cinemaName = inputLine[0];
                string movie = inputLine[1];
                decimal price = decimal.Parse(inputLine[2]);

                if (!IsNameCorrect(cinemaName))
                {
                    Console.WriteLine("Invalid cinema name");
                    continue;
                }
                
                if (!IsNameCorrect(movie))
                {
                    Console.WriteLine("Invalid movie name");
                    continue;
                }

                Cinema currentCinema = new Cinema(cinemaName);

                if (cinemas.All(c => c.CinemaName != cinemaName))
                {
                    cinemas.Add(currentCinema); 
                }

                Movie currentMovie = new Movie(movie, price);

               cinemas.First(c => c.CinemaName == cinemaName).Movies.Add(currentMovie);
            }

            foreach (var cinema in cinemas.OrderBy(c => c.CinemaName))
            {
                Console.WriteLine($"- {cinema.CinemaName}");
                foreach (var movie in cinema
                    .Movies
                    .OrderByDescending(m => m.MoviePrice))
                {
                    //Don't use :f2 for Price. It is not asked in conditions.
                    Console.WriteLine($"{movie.MovieName} : {movie.MoviePrice}");
                }
            }
        }

        private static bool IsNameCorrect(string name)
        {
            if (name.Length <= 20
                && !name.Contains('-')
                && !name.Contains('>'))
            {
                return true;
            }

            return false;
        }
    }
}
