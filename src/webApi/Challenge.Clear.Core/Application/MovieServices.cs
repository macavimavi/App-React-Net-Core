using Challenge.Clear.Application.Dtos;
using Challenge.Clear.Application.Helper;
using Challenge.Clear.Application.Interfaces.Repositories;
using Challenge.Clear.Application.Parameters;
using Challenge.Clear.Core.Domain.Mapper;
using Challenge.Clear.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Challenge.Clear.Domain
{
    public class MovieServices : IMovieServices
    {
        public readonly IMovieRepositoryAsync _movieRepositoryAsync;
        public readonly IMovieMapper _movieMapper;


        public MovieServices(IMovieRepositoryAsync movieRepositoryAsync, IMovieMapper movieMapper)
        {
            _movieRepositoryAsync = movieRepositoryAsync;
            _movieMapper = movieMapper;
        }


        private Expression<Func<Movie, bool>> GeneratePredicateByFilter(MoviesFilter parameter)
        {
            var predicate = PredicateBuilder.True<Movie>();

            if (!string.IsNullOrEmpty(parameter.Title))
            {
                predicate = predicate.And(m => m.Title.ToLower().StartsWith(parameter.Title));
            }

            if (!string.IsNullOrEmpty(parameter.ActorName))
            {
                //predicate = predicate.And(m => m.Actors.Select(x => x.Name.ToLower().StartsWith(parameter.ActorName)).Count() > 0);
            }

            if (parameter.GenreId > 0)
            {
                predicate = predicate.And(m => (int)m.Genre == parameter.GenreId);
            }


            return predicate;
        }


        public async Task<IEnumerable<MovieRequest>> GetMoviesAsync(MoviesFilter parameter)
        {
            var predicate = GeneratePredicateByFilter(parameter);
            //var entities = await _movieRepositoryAsync.GetSearchReponseAsync(predicate, parameter.PageNumber, parameter.PageSize);
            var entities = await _movieRepositoryAsync.GetAllAsync("MovieActor;MovieActor.Actor");
            return _movieMapper.Map(entities);
        }
    }
}
