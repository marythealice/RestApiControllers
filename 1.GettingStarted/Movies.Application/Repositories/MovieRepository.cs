using Movies.Application.Models;

namespace Movies.Application.Repositories;

public class MovieRepository : IMovieRepository
{
    public Task<bool> CreateAsync(Movie movie)
    {
        throw new NotImplementedException();
    }
}