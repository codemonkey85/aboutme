namespace aboutme.library.Pages;

public partial class Contact
{
    private List<ContactUrl> ContactUrlsList { get; set; } = new()
    {
        new()
        {
            Name = "Mastodon",
            Url = "https://mastodon.social/@codemonkey85",
            Title = "codemonkey85@mastodon.social on Mastodon",
            Icon = Icons.Material.Filled.OpenInBrowser,
        },
        new()
        {
            Name = "Threads",
            Url = "https://www.threads.net/@codemonkey85",
            Title = "Michael Bond (@codemonkey85) on Threads",
            Icon = Icons.Material.Filled.OpenInBrowser,
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
