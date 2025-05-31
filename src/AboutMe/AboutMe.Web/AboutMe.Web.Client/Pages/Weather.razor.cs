using Microsoft.AspNetCore.Components;

namespace AboutMe.Web.Client.Pages;

public partial class Weather(WeatherApiClient WeatherApi) : ComponentBase
{
    private List<WeatherForecast> forecasts = [];

    private bool IsLoading { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        try
        {
            IsLoading = true;
            var feed = await WeatherApi.GetWeatherAsync();

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
