using CleanMovie.Domain.Models;

namespace CleanMovie.Application.Repositories;

public interface IMovieRepository
{
    List<Movie> GetAllMovies();
}