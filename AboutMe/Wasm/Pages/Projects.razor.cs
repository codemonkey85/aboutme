namespace AboutMe.Wasm.Pages;

// ReSharper disable once UnusedType.Global
// ReSharper disable once ClassNeverInstantiated.Global
public partial class Projects
{
    private const string GitHubPagesBaseUrl = "https://codemonkey85.github.io";

    private List<Project> ProjectsList { get; } =
    [
        new()
        {
            Name = "BondCasts",
            Description = "A podcast client for iPhone, iPad, Mac, and Apple Watch",
            Url = "https://www.bondcasts.com/",
            Thumbnails = []
        }, // BondCasts
        new()
        {
            Name = "PKMDS for Web",
            Description = "A port of PKHeX for web, built wih Blazor",
            Url = "https://www.pkmds.app/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/PKMDS-Blazor",
            Thumbnails = []
        }, // PKMDS for Web
        new()
        {
            Name = "Sound Test",
            Description = "Messing around with the JavaScript tone APIs in Blazor",
            Url = $"{GitHubPagesBaseUrl}/SoundTest/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/SoundTest",
            Thumbnails = []
        }, // Sound Test
        new()
        {
            Name = "Tic Tac Toe Blazor",
            Description = "A Tic Tac Toe game for web, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/TicTacToeBlazor/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/TicTacToeBlazor",
            Thumbnails = []
        }, // Tic Tac Toe Blazor
        new()
        {
            Name = "Four Is The Magic Number!",
            Description = "A neat party trick, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/FourMagicNumberGame/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/FourMagicNumberGame",
            Thumbnails = []
        }, // Four Is The Magic Number!
        new()
        {
            Name = "Tired Doctor Manhattan",
            Description = "Doctor Manhattan is tired of stuff, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/TiredDoctorManhattan/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/TiredDoctorManhattan",
            Thumbnails = []
        } // Tired Doctor Manhattan
    ];

    private readonly record struct Project
    {
        public required string Name { get; init; }

        public string? Description { get; init; }

        public string? Url { get; init; }

        public string? GitHubUrl { get; init; }

        // ReSharper disable once CollectionNeverUpdated.Local
        public List<ProjectThumbnails> Thumbnails { get; init; }
    }

    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    private readonly record struct ProjectThumbnails
    {
        public required string Url { get; init; }

        public required string Title { get; init; }
    }
}
