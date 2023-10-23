namespace AboutMe.Components.Layout;
public partial class MainLayout
{
    protected bool drawerOpen = true;
    private bool isDarkMode;
    private MudThemeProvider? mudThemeProvider;

    protected void DrawerToggle() => drawerOpen = !drawerOpen;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && mudThemeProvider is not null)
        {
            isDarkMode = await mudThemeProvider.GetSystemPreference();
            await mudThemeProvider.WatchSystemPreference(OnSystemPreferenceChanged);
            StateHasChanged();
        }
    }
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    private async Task OnSystemPreferenceChanged(bool newValue)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    {
        isDarkMode = newValue;
        StateHasChanged();
    }
}
