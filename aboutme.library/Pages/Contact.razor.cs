namespace aboutme.library.Pages;

public partial class Contact
{
    private List<ContactUrl> ContactUrlsList { get; set; } = new()
    {
        new()
        {
            Name = "GitHub",
            Url = "https://github.com/codemonkey85",
            Title = "codemonkey85 on GitHub",
        },
        new()
        {
            Name = "Mastodon",
            Url = "https://mastodon.social/@codemonkey85",
            Title = "codemonkey85@mastodon.social on Mastodon",
        },
        new()
        {
            Name = "Threads",
            Url = "https://www.threads.net/@codemonkey85",
            Title = "codemonkey85 on Threads",
        },
        new()
        {
            Name = "Twitter / X",
            Url = "https://twitter.com/codemonkey85",
            Title = "codemonkey85 on Twitter / X",
        },
        new()
        {
            Name = "Bluesky",
            Url = "https://bsky.app/profile/codemonkey85.bsky.social",
            Title = "codemonkey85.bsky.social on BlueSky",
        },
    };

    private class ContactUrl
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public string Icon { get; set; } = Icons.Material.Filled.OpenInBrowser;
    }
}
