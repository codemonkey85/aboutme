namespace AboutMe.Wasm.Pages;

// ReSharper disable once UnusedType.Global
public partial class Now(HttpClient httpClient)
{
    private List<NowThing> NowThings { get; set; } = [];

    private bool IsLoading { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        const string TestApiBaseUrl =
#if DEBUG
                "https://localhost:7239/"
#else
"https://codemonkey85.azurewebsites.net/"
#endif
            ;

        try
        {
            IsLoading = true;
            var nowThings = await httpClient.GetFromJsonAsync<NowThing[]>(
                TestApiBaseUrl + "now",
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            if (nowThings is not null && nowThings.Length > 0)
            {
                NowThings = [.. nowThings]; // Copy the array to the list
            }
            else
            {
                Console.WriteLine("No 'now' items found.");
            }

            IsLoading = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading feed: {ex.Message}");
        }
    }

    private readonly record struct NowThing
    {
        public string Title { get; init; }

        public string Description { get; init; }

        public string? Url { get; init; }
    }
}
