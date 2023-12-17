namespace AboutMe.Wasm.Pages;

public partial class Projects
{
    private List<Project> ProjectsList { get; set; } =
    [
        new()
        {
            Name = "PKMDS Blazor",
            Description = "A port of PKHeX for web, built wih Blazor",
            WebUrl = "https://delightful-grass-0e57f8c0f.2.azurestaticapps.net/",
            GitHubUrl = "https://github.com/codemonkey85/PKMDS-Blazor",
            Screenshots = [],
        },
        new()
        {
            Name = "Sound Test",
            Description = "Messing around with the JavaScript tone APIs in Blazor",
            WebUrl = "https://polite-wave-0e108230f.azurestaticapps.net/",
            GitHubUrl = "https://github.com/codemonkey85/SoundTest",
            Screenshots = [],
        },
        new()
        {
            Name = "Tic Tac Toe Blazor",
            Description = "A Tic Tac Toe game for web, built with Blazor",
            WebUrl = "https://codemonkey85.github.io/TicTacToeBlazor/",
            GitHubUrl = "https://github.com/codemonkey85/TicTacToeBlazor",
            Screenshots = [],
        },
        new()
        {
            Name = "Four Is The Magic Number!",
            Description = "A neat party trick, built with Blazor",
            WebUrl = "https://black-sea-00acdf50f.azurestaticapps.net/",
            GitHubUrl = "https://github.com/codemonkey85/FourMagicNumberGame",
            Screenshots = [],
        },
    ];

    private class Project
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? WebUrl { get; set; }

        public string? GitHubUrl { get; set; }

        public List<ProductImage> Screenshots { get; set; } = [];
    }

    private class ProductImage
    {
        required public string Url { get; set; }

        required public string Title { get; set; }
    }
}
