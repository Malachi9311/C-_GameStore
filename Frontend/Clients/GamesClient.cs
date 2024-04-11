using Frontend.Models;
namespace Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
    [
    new(){
Id = 1,
Name = "Street Jumper II",
Genre = "Kids",
Price = 19.99M,
ReleaseDate = new DateOnly(1992, 7, 15)
},
new(){
Id = 2,
Name = "King of Fighters 03",
Genre = "Action",
Price = 29.99M,
ReleaseDate = new DateOnly(2003, 1, 12)
},
new(){
Id = 3,
Name = "Hitman: Codename 47",
Genre = "Adventure",
Price = 31.99M,
ReleaseDate = new DateOnly(1999, 4, 5)
},
new(){
Id = 4,
Name = "fifa 16",
Genre = "Sport",
Price = 49.99M,
ReleaseDate = new DateOnly(2016, 8, 16)
}
];

    public GameSummary[] GetGames() => games.ToArray();
}
