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
        },
    };

    private class ContactUrl
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
    }
}
