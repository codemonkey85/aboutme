namespace AboutMe.Web.Client.Pages;

public partial class Blog(BlogApiClient BlogApiClient)
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
            try
            {
                IsLoading = true;
                StateHasChanged();

                var feed = await BlogApiClient.GetNowThings();

                if (feed?.Length is > 0)
                {
                    Posts = [.. feed.Take(10)]; // Get the last 10 posts
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
