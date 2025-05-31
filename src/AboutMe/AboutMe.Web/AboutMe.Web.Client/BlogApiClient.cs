namespace AboutMe.Web.Client;

public class BlogApiClient(HttpClient httpClient)
{
    public async Task<Item[]> GetNowThings(
        int maxItems = 10,
        CancellationToken cancellationToken = default)
    {
        List<Item>? blogPosts = null;

        await foreach (var blogPost in httpClient
            .GetFromJsonAsAsyncEnumerable<Item>("/blog", cancellationToken))
        {
            if (blogPosts?.Count >= maxItems)
            {
                break;
            }

            blogPosts ??= [];
            blogPosts.Add(blogPost);
        }

        return blogPosts?.ToArray() ?? [];
    }
}
