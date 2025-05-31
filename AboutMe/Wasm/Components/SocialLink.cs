namespace AboutMe.Wasm.Components;

public readonly record struct SocialLink
{
    public SocialLink()
    {
    }

    public string? Name { get; init; }

    public string? Url { get; init; }

    public string? Title { get; init; }

    public string Icon { get; init; } = Icons.Material.Filled.OpenInBrowser;

    public bool OpenInNewWindow { get; init; } = true;

    public static SocialLink EmailMe { get; } = new()
    {
        Name = "Email me",
        Url = "mailto:michael@bondcodes.com",
        Title = "Email me",
        Icon = Icons.Material.Filled.Email
    };

    public static SocialLink MyGitHub { get; } = new()
    {
        Name = "Michael Bond on GitHub",
        Url = Constants.MyGitHubBaseUrl,
        Title = "Michael Bond on GitHub",
        Icon = Icons.Custom.Brands.GitHub
    };

    public static SocialLink SupportMe { get; } = new()
    {
        Name = "Support me",
        Url = "support",
        Title = "Support me",
        OpenInNewWindow = false,
        Icon = Icons.Material.Filled.Coffee
    };
}
