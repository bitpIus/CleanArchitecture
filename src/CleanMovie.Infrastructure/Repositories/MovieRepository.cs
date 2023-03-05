
using CleanMovie.Application.Repositories;
using CleanMovie.Domain.Models;

namespace CleanMovie.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    public List<Movie> Movies { get; set; }

    public MovieRepository()
    {
        Movies = new List<Movie>()
        {
            new Movie { Id = 1,Name="Test Movie 1 ",Price=5.64m},
            new Movie { Id = 2,Name="Test Movie 2 ",Price=5.64m},
            new Movie { Id = 3,Name="Test Movie 3 ",Price=5.64m},
        };
    }

    public List<Movie> GetAllMovies()
    {
        return Movies;
    }

}
