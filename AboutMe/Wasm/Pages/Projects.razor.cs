namespace AboutMe.Wasm.Pages;

public partial class Projects
{
    private const string GitHubPagesBaseUrl = "https://codemonkey85.github.io";

    private List<Project> ProjectsList { get; set; } =
    [
        new Project
        {
            Name = "PKMDS Blazor",
            Description = "A port of PKHeX for web, built wih Blazor",
            Url = "https://www.pkmds.app/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/PKMDS-Blazor",
            Screenshots = [],
        }, // PKMDS Blazor
        new Project
        {
            Name = "Sound Test",
            Description = "Messing around with the JavaScript tone APIs in Blazor",
            Url = $"{GitHubPagesBaseUrl}/SoundTest/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/SoundTest",
            Screenshots = [],
        }, // Sound Test
        new Project
        {
            Name = "Tic Tac Toe Blazor",
            Description = "A Tic Tac Toe game for web, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/TicTacToeBlazor/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/TicTacToeBlazor",
            Screenshots = [],
        }, // Tic Tac Toe Blazor
        new Project
        {
            Name = "Four Is The Magic Number!",
            Description = "A neat party trick, built with Blazor",
            Url = $"{GitHubPagesBaseUrl}/FourMagicNumberGame/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/FourMagicNumberGame",
            Screenshots = [],
        }, // Four Is The Magic Number!
        new Project
        {
            Name = "Barcode Helper",
            Description = "Solve the missing digit in a UPC-12",
            Url = $"{GitHubPagesBaseUrl}/BarcodeHelper/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/BarcodeHelper",
            Screenshots = [],
        }, // Barcode Helper
        new Project
        {
            Name = "Tired Doctor Manhattan",
            Description = "Doctor Manhattan is tired of stuff",
            Url = $"{GitHubPagesBaseUrl}/TiredDoctorManhattan/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/TiredDoctorManhattan",
            Screenshots = [],
        }, // Tired Doctor Manhattan
        new Project
        {
            Name = "Minecraft Command Builder",
            Description = "A tool to help build Minecraft commands",
            Url = $"{GitHubPagesBaseUrl}/MinecraftCommandBuilder/",
            GitHubUrl = $"{Constants.MyGitHubBaseUrl}/MinecraftCommandBuilder",
            Screenshots = [],
        }, // Minecraft Command Builder
    ];

    private struct Project
    {
        public required string Name { get; init; }

        public string? Description { get; init; }

        public string? Url { get; init; }

        public string? GitHubUrl { get; init; }

        public List<ProductImage> Screenshots { get; init; }
    }

    private struct ProductImage
    {
        public required string Url { get; set; }

        public required string Title { get; set; }
    }
}
