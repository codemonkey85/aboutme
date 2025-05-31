namespace AboutMe.ApiService.Endpoints;

public static class BlogEndpoints
{
    public static IEndpointRouteBuilder MapBlogEndpoints(
        this IEndpointRouteBuilder app)
    {
        app.MapGet("/blog", async (HttpClient httpClient) => await GetBlogPosts(httpClient));

        return app;
    }

    private static readonly JsonSerializerOptions JsonSerializerOptions =
    new()
    {
        PropertyNameCaseInsensitive = true,
        TypeInfoResolver = FeedJsonContext.Default
    };

    private static async Task<IResult> GetBlogPosts(HttpClient httpClient)
    {
        const string feedUrl = "https://micro.bondcodes.com/feed.json";
        List<Item> blogPosts = [];

        var feed = await httpClient.GetFromJsonAsync<Feed>(feedUrl, JsonSerializerOptions);

        if (feed.Items != null)
        {
            blogPosts = feed.Items;
        }

        return Results.Ok(blogPosts);
    }
}
