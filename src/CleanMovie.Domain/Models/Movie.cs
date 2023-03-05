namespace CleanMovie.Domain.Models;

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
