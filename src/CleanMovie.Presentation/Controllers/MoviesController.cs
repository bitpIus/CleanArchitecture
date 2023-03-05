
using CleanMovie.Application.Interfaces;
using CleanMovie.Domain.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public ActionResult<List<Movie>> Get()
    {
        var result = _movieService.GetAllMovies();

        return Ok(result);
    }
}