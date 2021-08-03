using Challenge.Clear.Application.Dtos;
using Challenge.Clear.Application.Parameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.Clear.Domain
{
    public interface IMovieServices
    {
        Task<IEnumerable<MovieRequest>> GetMoviesAsync(MoviesFilter parameter);
    }
}