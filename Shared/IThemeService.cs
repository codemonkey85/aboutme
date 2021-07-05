using System.Threading.Tasks;

namespace aboutme.Shared
{
    public interface IThemeService
    {
        Task ReadThemeFromLocalStorage();

        Task WriteThemeToLocalStorage();

        Task SetTheme(IRefreshService RefreshService, bool isDark);

        Task ApplyTheme(IRefreshService refreshService);

        Task SwitchTheme(IRefreshService RefreshService);
    }
}
