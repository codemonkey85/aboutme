namespace AboutMe.Wasm.Pages;

// ReSharper disable once UnusedType.Global
public partial class Blog(HttpClient httpClient)
{
    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string DateFormat = "ddd MMM dd yyyy hh:mm tt";

    private static readonly JsonSerializerOptions JsonSerializerOptions =
        new() { PropertyNameCaseInsensitive = true, TypeInfoResolver = FeedJsonContext.Default };

    private List<Item> Posts { get; set; } = [];

    private bool IsLoading { get; set; }

    protected override async Task OnInitializedAsync()
    {
        const string feedUrl = "https://micro.bondcodes.com/feed.json";
        try
        {
            IsLoading = true;
            var feed = await httpClient.GetFromJsonAsync<Feed>(feedUrl, JsonSerializerOptions);

            if (feed != null)
            {
                Posts = feed.Items.Take(10).ToList(); // Get the last 10 posts
            }

            IsLoading = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading feed: {ex.Message}");
        }
    }
}

[JsonSerializable(typeof(Feed[]))]
// ReSharper disable once ClassNeverInstantiated.Global
internal partial class FeedJsonContext : JsonSerializerContext;

public class Feed
{
    [JsonPropertyName("version")]
    public string Version { get; init; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; init; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; init; } = string.Empty;

    [JsonPropertyName("home_page_url")]
    public string HomePageUrl { get; init; } = string.Empty;

    [JsonPropertyName("feed_url")]
    public string FeedUrl { get; init; } = string.Empty;

    // ReSharper disable once CollectionNeverUpdated.Global
    [JsonPropertyName("items")]
    public List<Item> Items { get; init; } = [];
}

// ReSharper disable once ClassNeverInstantiated.Global
[SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Global")]
public class Item
{
    // ReSharper disable once UnusedMember.Global
    [JsonPropertyName("id")]
    public string Id { get; init; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; init; } = string.Empty;

    [JsonPropertyName("content_html")]
    public string ContentHtml { get; init; } = string.Empty;

    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    [JsonPropertyName("date_published")]
    public DateTime DatePublished { get; init; }

    [JsonPropertyName("url")]
    public string Url { get; init; } = string.Empty;
}
