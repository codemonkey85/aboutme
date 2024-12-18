using System.Text.Json;
using System.Text.Json.Serialization;

namespace AboutMe.Wasm.Pages;

// ReSharper disable once UnusedType.Global
public partial class Blog
{
    private string feedTitle = string.Empty;
    private List<Item> posts = [];

    protected override async Task OnInitializedAsync()
    {
        try
        {
            const string feedUrl = "https://micro.bondcodes.com/feed.json";
            var jsonResponse = await Http.GetStringAsync(feedUrl);

            var feed = JsonSerializer.Deserialize<Feed>(jsonResponse,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (feed != null)
            {
                feedTitle = feed.Title;
                posts = feed.Items.Take(10).ToList(); // Get the last 10 posts
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading feed: {ex.Message}");
        }
    }
}

[JsonSerializable(typeof(Feed))]
public class Feed
{
    [JsonPropertyName("version")]
    public string Version { get; set; } = "";
    [JsonPropertyName("title")]
    public string Title { get; set; } = "";
    [JsonPropertyName("icon")]
    public string Icon { get; set; } = "";
    [JsonPropertyName("home_page_url")]
    public string HomePageUrl { get; set; } = "";
    [JsonPropertyName("feed_url")]
    public string FeedUrl { get; set; } = "";

    // ReSharper disable once CollectionNeverUpdated.Global
    [JsonPropertyName("items")]
    public List<Item> Items { get; set; } = [];
}

// ReSharper disable once ClassNeverInstantiated.Global
public class Item
{
    // ReSharper disable once UnusedMember.Global
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    [JsonPropertyName("title")]
    public string Title { get; set; } = "";
    [JsonPropertyName("content_text")]
    public string ContentHtml { get; set; } = "";
    [JsonPropertyName("date_published")]
    public DateTime DatePublished { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}
