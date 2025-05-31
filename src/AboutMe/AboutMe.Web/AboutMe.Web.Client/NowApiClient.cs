namespace AboutMe.Web.Client;

public class NowApiClient(HttpClient httpClient)
{
    public async Task<NowThing[]> GetNowThings(
        int maxItems = 10,
        CancellationToken cancellationToken = default)
    {
        List<NowThing>? nowThings = null;

        await foreach (var nowThing in httpClient
            .GetFromJsonAsAsyncEnumerable<NowThing>("/now", cancellationToken))
        {
            if (nowThings?.Count >= maxItems)
            {
                break;
            }
            nowThings ??= [];
            nowThings.Add(nowThing);
        }

        return nowThings?.ToArray() ?? [];
    }
}
