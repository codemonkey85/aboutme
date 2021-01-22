using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace aboutme.Shared
{
    public interface IThemeService
    {
        Task ReadThemeFromLocalStorage(IJSRuntime jSRuntime);

        Task WriteThemeToLocalStorage(IJSRuntime jSRuntime);

        Task SetTheme(IJSRuntime JSRuntime, IRefreshService RefreshService, bool isDark);

        Task ApplyTheme(IJSRuntime jSRuntime, IRefreshService refreshService);

        Task SwitchTheme(IJSRuntime JSRuntime, IRefreshService RefreshService);
    }
}
