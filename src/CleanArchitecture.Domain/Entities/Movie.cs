namespace CleanArchitecture.Domain.Entities;

public class Movie
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string Description { get; set; }
    
}