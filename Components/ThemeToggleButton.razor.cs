using aboutme.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace aboutme.Components
{
    public partial class ThemeToggleButton : ComponentBase
    {
        [Inject]
        public IJSRuntime JSRuntime
        {
            get; set;
        }

        [Inject]
        private IRefreshService RefreshService
        {
            get; set;
        }

        [Inject]
        private IThemeService ThemeService
        {
            get; set;
        }

        protected override async Task OnInitializedAsync()
        {
            await ThemeService.ReadThemeFromLocalStorage(JSRuntime);
            await ThemeService.ApplyTheme(JSRuntime, RefreshService);
        }

        private async Task SetTheme(bool isDark)
        {
            await ThemeService.SetTheme(JSRuntime, RefreshService, isDark);
            RefreshService.CallRequestRefresh();
        }

        private async Task SwitchTheme() => await ThemeService.SwitchTheme(JSRuntime, RefreshService);
    }
}
