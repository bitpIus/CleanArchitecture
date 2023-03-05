using CleanMovie.Domain.Models;

namespace CleanMovie.Application.Interfaces;

public interface IMovieService
{
    List<Movie> GetAllMovies();
}