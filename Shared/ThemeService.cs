using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace aboutme.Shared
{
    public class ThemeService : IThemeService
    {
        private bool isDarkTheme = false;
        private const string isDarkThemeKey = @"isDarkTheme";

        public async Task ReadThemeFromLocalStorage(IJSRuntime jSRuntime) =>
            isDarkTheme = int.Parse(await jSRuntime.ReadFromLocalStorage(isDarkThemeKey, "0")) == 1;

        public async Task WriteThemeToLocalStorage(IJSRuntime jSRuntime) =>
            await jSRuntime.AddToLocalStorage(isDarkThemeKey, isDarkTheme ? 1 : 0);

        public async Task SetTheme(IJSRuntime jSRuntime, IRefreshService refreshService, bool isDark)
        {
            isDarkTheme = isDark;
            await WriteThemeToLocalStorage(jSRuntime);
            await ApplyTheme(jSRuntime, refreshService);
        }

        public async Task ApplyTheme(IJSRuntime jSRuntime, IRefreshService refreshService)
        {
            await jSRuntime.ChangeTheme(isDarkTheme);
            refreshService.CallRequestRefresh();
        }

        public async Task SwitchTheme(IJSRuntime jSRuntime, IRefreshService refreshService) =>
            await SetTheme(jSRuntime, refreshService, !isDarkTheme);
    }
}
