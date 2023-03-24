namespace aboutme.library.Pages;

public partial class Projects
{
    private List<Project> ProjectsList { get; set; } = new()
    {
        new
        (
            Name: "Four Is The Magic Number!",
            Description: "",
            WebUrl: "https://black-sea-00acdf50f.azurestaticapps.net/",
            GitHubUrl: "https://github.com/codemonkey85/FourMagicNumberGame",
            ScreenshotUrl: ""
        ),
        new
        (
            Name: "Tic Tac Toe Blazor",
            Description: "",
            WebUrl: "https://codemonkey85.github.io/TicTacToeBlazor/",
            GitHubUrl: "https://github.com/codemonkey85/TicTacToeBlazor",
            ScreenshotUrl: ""
        ),
        new
        (
            Name: "Sound Test",
            Description: "",
            WebUrl: "https://polite-wave-0e108230f.azurestaticapps.net/",
            GitHubUrl: "https://github.com/codemonkey85/SoundTest",
            ScreenshotUrl: ""
        ),
    };

    private record Project(string Name, string Description, string WebUrl, string GitHubUrl, string ScreenshotUrl);
}
