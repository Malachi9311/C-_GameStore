using Frontend.Models;
namespace Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] genres = 
    [
        new(){
            Id = 1,
            Name = "Action"
        },
        new(){
            Id = 2,
            Name = "Sport"
        },
        new(){
            Id = 3,
            Name = "Adventure"
        },
        new(){
            Id = 4,
            Name = "Racing"
        },
        new(){
            Id = 5,
            Name = "Kids"
        }
    ];

    public Genre[] GetGenres() => genres;
}
