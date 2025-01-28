namespace AboutMe.Wasm.Pages;

// ReSharper disable once UnusedType.Global
public partial class Now
{
    private List<NowThing> NowThings { get; } =
    [
        new() { Title = "Working on", Description = "This site", Url = null }
    ];

    private readonly record struct NowThing
    {
        public string Title { get; init; }

        public string Description { get; init; }

        public string? Url { get; init; }
    }
}
