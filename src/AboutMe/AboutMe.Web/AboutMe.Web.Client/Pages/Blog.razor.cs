namespace AboutMe.Web.Client.Pages;

// ReSharper disable once UnusedType.Global
// ReSharper disable once ClassNeverInstantiated.Global
public partial class Blog(HttpClient httpClient)
{
    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string DateFormat = "ddd MMM dd yyyy hh:mm tt";

    private static readonly JsonSerializerOptions JsonSerializerOptions =
        new()
        {
            PropertyNameCaseInsensitive = true,
            TypeInfoResolver = FeedJsonContext.Default
        };

    private List<Item> Posts { get; set; } = [];

    private bool IsLoading { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        const string feedUrl = "https://micro.bondcodes.com/feed.json";
        try
        {
            IsLoading = true;
            var feed = await httpClient.GetFromJsonAsync<Feed>(feedUrl, JsonSerializerOptions);

            if (feed.Items.Count != 0)
            {
                Posts = [.. feed.Items.Take(10)]; // Get the last 10 posts
            }

            IsLoading = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading feed: {ex.Message}");
        }
    }
}
