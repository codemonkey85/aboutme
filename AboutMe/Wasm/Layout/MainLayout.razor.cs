namespace AboutMe.Wasm.Layout;

public partial class MainLayout
{
    private bool drawerOpen = true;
    private bool isDarkMode;
    private MudThemeProvider? mudThemeProvider;

    protected void DrawerToggle() => drawerOpen = !drawerOpen;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && mudThemeProvider is not null)
        {
            isDarkMode = await mudThemeProvider.GetSystemDarkModeAsync();
            await mudThemeProvider.WatchSystemDarkModeAsync(OnSystemPreferenceChanged);
            StateHasChanged();
        }
    }

    private Task OnSystemPreferenceChanged(bool newValue)
    {
        try
        {
            isDarkMode = newValue;
            StateHasChanged();
            return Task.CompletedTask;
        }
        catch (Exception exception)
        {
            return Task.FromException(exception);
        }
    }
}
