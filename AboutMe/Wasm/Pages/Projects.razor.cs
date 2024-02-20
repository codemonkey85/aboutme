namespace AboutMe.Wasm.Pages;

public partial class Projects
{
    private List<Project> ProjectsList { get; set; } =
    [
        new()
        {
            Name = "PKMDS Blazor",
            Description = "A port of PKHeX for web, built wih Blazor",
            Url = "https://www.pkmds.app/",
            GitHubUrl = "https://github.com/codemonkey85/PKMDS-Blazor",
            Screenshots = [],
        }, // PKMDS Blazor
        new()
        {
            Name = "Sound Test",
            Description = "Messing around with the JavaScript tone APIs in Blazor",
            Url = "https://codemonkey85.github.io/SoundTest/",
            GitHubUrl = "https://github.com/codemonkey85/SoundTest",
            Screenshots = [],
        }, // Sound Test
        new()
        {
            Name = "Tic Tac Toe Blazor",
            Description = "A Tic Tac Toe game for web, built with Blazor",
            Url = "https://codemonkey85.github.io/TicTacToeBlazor/",
            GitHubUrl = "https://github.com/codemonkey85/TicTacToeBlazor",
            Screenshots = [],
        }, // Tic Tac Toe Blazor
        new()
        {
            Name = "Four Is The Magic Number!",
            Description = "A neat party trick, built with Blazor",
            Url = "https://codemonkey85.github.io/FourMagicNumberGame/",
            GitHubUrl = "https://github.com/codemonkey85/FourMagicNumberGame",
            Screenshots = [],
        }, // Four Is The Magic Number!
        new()
        {
            Name = "Barcode Helper",
            Description = "Solve the missing digit in a UPC-12",
            Url = "https://codemonkey85.github.io/BarcodeHelper/",
            GitHubUrl = "https://github.com/codemonkey85/BarcodeHelper",
            Screenshots = [],
        }, // Barcode Helper
        new()
        {
            Name = "Tired Doctor Manhattan",
            Description = "Doctor Manhattan is tired of stuff",
            Url = "https://codemonkey85.github.io/TiredDoctorManhattan/",
            GitHubUrl = "https://github.com/codemonkey85/TiredDoctorManhattan",
            Screenshots = [],
        }, // Tired Doctor Manhattan
        new()
        {
            Name = "Minecraft Command Builder",
            Description = "A tool to help build Minecraft commands",
            Url = "https://codemonkey85.github.io/MinecraftCommandBuilder/",
            GitHubUrl = "https://github.com/codemonkey85/MinecraftCommandBuilder",
            Screenshots = [],
        }, // Minecraft Command Builder
    ];

    private struct Project
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public string? Url { get; set; }

        public string? GitHubUrl { get; set; }

        public List<ProductImage> Screenshots { get; set; }
    }

    private struct ProductImage
    {
        public required string Url { get; set; }

        public required string Title { get; set; }
    }
}
