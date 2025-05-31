namespace AboutMe.Shared.Models;

public record NowThing
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string? Url { get; set; }
}
