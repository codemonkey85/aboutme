namespace AboutMe.Web.Client.Pages;

public partial class Weather(WeatherApiClient WeatherApiClient)
{
    private List<WeatherForecast> forecasts = [];

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

                var feed = await WeatherApiClient.GetWeatherAsync();

                if (feed?.Length is > 0)
                {
                    forecasts = [.. feed];
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
