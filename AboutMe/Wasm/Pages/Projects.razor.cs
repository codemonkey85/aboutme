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
            Name = "Barcode Helper",
            Description = "Solve the missing digit in a UPC-12, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/BarcodeHelper/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/BarcodeHelper",
            Thumbnails = []
        }, // Barcode Helper
        new()
        {
            Name = "Tired Doctor Manhattan",
            Description = "Doctor Manhattan is tired of stuff, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/TiredDoctorManhattan/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/TiredDoctorManhattan",
            Thumbnails = []
        }, // Tired Doctor Manhattan
        new()
        {
            Name = "Minecraft Command Builder",
            Description = "A tool to help build Minecraft commands, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/MinecraftCommandBuilder/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/MinecraftCommandBuilder",
            Thumbnails = []
        }, // Minecraft Command Builder
        new()
        {
            Name = "D&D Critical Hit Calculator",
            Description = "Honestly, this is just for me and my D&D friends.",
            Url = $"{GitHubPagesBaseUrl}/DnDCritCalculator/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/DnDCritCalculator",
            Thumbnails = []
        } // D&D Critical Hit Calculator
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
