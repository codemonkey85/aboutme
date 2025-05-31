using static AboutMe.Web.Client.NowApiClient;

namespace AboutMe.Web.Client.Pages;

public partial class Now(NowApiClient httpClient)
{
    private List<NowThing> nowThings = [];

    private bool IsLoading { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        try
        {
            IsLoading = true;
            var feed = await httpClient.GetNowThings();

            if (feed?.Length is > 0)
            {
                nowThings = [.. feed];
            }

            IsLoading = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading feed: {ex.Message}");
        }
    }
}
