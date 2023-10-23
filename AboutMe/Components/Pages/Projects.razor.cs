namespace AboutMe.Components.Pages;

public partial class Projects
{
    private List<Project> ProjectsList { get; set; } = new()
    {
        new()
        {
            Name = "PKMDS Blazor",
            Description = "",
            WebUrl = "https://delightful-grass-0e57f8c0f.2.azurestaticapps.net/",
            GitHubUrl = "https://github.com/codemonkey85/PKMDS-Blazor",
            ScreenshotUrl = "",
        },
        new()
        {
            Name = "Sound Test",
            Description = "",
            WebUrl = "https://polite-wave-0e108230f.azurestaticapps.net/",
            GitHubUrl = "https://github.com/codemonkey85/SoundTest",
            ScreenshotUrl = "",
        },
        new()
        {
            Name = "Tic Tac Toe Blazor",
            Description = "",
            WebUrl = "https://codemonkey85.github.io/TicTacToeBlazor/",
            GitHubUrl = "https://github.com/codemonkey85/TicTacToeBlazor",
            ScreenshotUrl = "",
        },
        new()
        {
            Name = "Four Is The Magic Number!",
            Description = "",
            WebUrl = "https://black-sea-00acdf50f.azurestaticapps.net/",
            GitHubUrl = "https://github.com/codemonkey85/FourMagicNumberGame",
            ScreenshotUrl = "",
        },
    };

    private class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? WebUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? ScreenshotUrl { get; set; }
    }
}
