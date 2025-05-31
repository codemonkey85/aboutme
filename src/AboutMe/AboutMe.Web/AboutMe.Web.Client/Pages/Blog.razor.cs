namespace AboutMe.Web.Client.Pages;

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

    private bool HasLoaded { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (firstRender && !HasLoaded)
        {
            HasLoaded = true;
            await LoadFeedAsync();
            StateHasChanged();
        }

        async Task LoadFeedAsync()
        {
            const string feedUrl = "https://micro.bondcodes.com/feed.json";
            try
            {
                IsLoading = true;
                StateHasChanged();

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
}
