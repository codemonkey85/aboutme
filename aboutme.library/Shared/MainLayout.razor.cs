namespace aboutme.library.Shared;

public partial class MainLayout
{
    protected bool _drawerOpen = true;
    private bool _isDarkMode;
    private MudThemeProvider? _mudThemeProvider;

    protected void DrawerToggle() => _drawerOpen = !_drawerOpen;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && _mudThemeProvider is not null)
        {
            _isDarkMode = await _mudThemeProvider.GetSystemPreference();
            await _mudThemeProvider.WatchSystemPreference(OnSystemPreferenceChanged);
            StateHasChanged();
        }
    }
    private async Task OnSystemPreferenceChanged(bool newValue)
    {
        _isDarkMode = newValue;
        StateHasChanged();
    }
}
