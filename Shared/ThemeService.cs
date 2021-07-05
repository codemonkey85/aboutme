using System.Threading.Tasks;

namespace aboutme.Shared
{
    public class ThemeService : IThemeService
    {
        private bool isDarkTheme = false;
        private const string isDarkThemeKey = @"isDarkTheme";

        private JsInterop JsInterop { get; set; }

        public ThemeService(JsInterop jsInterop) => JsInterop = jsInterop;

        public async Task ReadThemeFromLocalStorage() =>
            isDarkTheme = int.TryParse(await JsInterop.ReadFromLocalStorage(isDarkThemeKey, "0"), out int result) && result == 1;

        public async Task WriteThemeToLocalStorage() =>
            await JsInterop.AddToLocalStorage(isDarkThemeKey, isDarkTheme ? 1 : 0);

        public async Task SetTheme(IRefreshService refreshService, bool isDark)
        {
            isDarkTheme = isDark;
            await WriteThemeToLocalStorage();
            await ApplyTheme(refreshService);
        }

        public async Task ApplyTheme(IRefreshService refreshService)
        {
            await JsInterop.ChangeTheme(isDarkTheme);
            refreshService.CallRequestRefresh();
        }

        public async Task SwitchTheme(IRefreshService refreshService) =>
            await SetTheme(refreshService, !isDarkTheme);
    }
}
