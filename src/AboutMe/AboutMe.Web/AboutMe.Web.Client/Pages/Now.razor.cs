namespace AboutMe.Web.Client.Pages;

public partial class Now(NowApiClient NowApiClient)
{
    private List<NowThing> nowThings = [];

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

                var feed = await NowApiClient.GetNowThings();

                if (feed?.Length is > 0)
                {
                    nowThings = [.. feed];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading feed: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
