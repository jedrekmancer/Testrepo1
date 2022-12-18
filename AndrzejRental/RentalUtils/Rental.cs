using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.RentalUtils
{
    internal class Rental
    {
        private List<IMovie> _movies = new List<IMovie>();

        public void AddMovie(IMovie movie)
        {
            _movies.Add(movie);
        }

        public IMovie Find(string movieTitle)
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                if (_movies[i].GetTitle() == movieTitle)
                {
                    return _movies[i];
                }
            }
            return null;

        }





    }
}
