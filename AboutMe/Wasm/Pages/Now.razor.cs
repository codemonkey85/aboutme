namespace AboutMe.Wasm.Pages;

public partial class Now
{
    private List<NowThing> NowThings { get; set; } =
    [
    ];
    private struct NowThing
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string? Url { get; set; }
    }
}
