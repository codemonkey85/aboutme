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

            if (feed.Items.Count != 0)
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

    [JsonSerializable(typeof(Feed[]))]
    // ReSharper disable once ClassNeverInstantiated.Global
    private partial class FeedJsonContext : JsonSerializerContext;

    private readonly record struct Feed
    {
        [JsonPropertyName("version")]
        public string Version { get; init; }

        [JsonPropertyName("title")]
        public string Title { get; init; }

        [JsonPropertyName("icon")]
        public string Icon { get; init; }

        [JsonPropertyName("home_page_url")]
        public string HomePageUrl { get; init; }

        [JsonPropertyName("feed_url")]
        public string FeedUrl { get; init; }

        // ReSharper disable once CollectionNeverUpdated.Global
        [JsonPropertyName("items")]
        public List<Item> Items { get; init; }
    }

// ReSharper disable once ClassNeverInstantiated.Global
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Global")]
    private readonly record struct Item
    {
        // ReSharper disable once UnusedMember.Global
        [JsonPropertyName("id")]
        public string Id { get; init; }

        [JsonPropertyName("title")]
        public string Title { get; init; }

        [JsonPropertyName("content_html")]
        public string ContentHtml { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        [JsonPropertyName("date_published")]
        public DateTime DatePublished { get; init; }

        [JsonPropertyName("url")]
        public string Url { get; init; }
    }
}
