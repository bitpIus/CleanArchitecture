using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Repositories;
using CleanMovie.Domain.Models;

namespace CleanMovie.Application.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public List<Movie> GetAllMovies()
    {
        var movies = _movieRepository.GetAllMovies();

        return movies;
    }
}