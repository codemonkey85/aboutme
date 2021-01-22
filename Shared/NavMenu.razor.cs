using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace aboutme.Shared
{
    public partial class NavMenu : ComponentBase
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

        protected bool collapseNavMenu = true;
        protected bool isDark = false;

        protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected override async Task OnInitializedAsync()
        {
            RefreshService.RefreshRequested += StateHasChanged;
        }

        protected void ToggleNavMenu() => collapseNavMenu = !collapseNavMenu;

        protected MarkdownPage[] Pages =
        {
            new MarkdownPage("", "Index", NavLinkMatch.All, "oi oi-home"),
            new MarkdownPage("resume", "Resume", NavLinkMatch.All, "oi oi-document"),
            new MarkdownPage("music", "Music I Like", NavLinkMatch.All, "oi oi-document"),
            new MarkdownPage("pokemon", "Pokémon", NavLinkMatch.All, "oi oi-document"),
            new MarkdownPage("contact", "Contact Me", NavLinkMatch.All, "oi oi-document"),
        };

        private async Task SetTheme(bool isDark)
        {
            await JSRuntime.ChangeTheme(this.isDark = isDark);
            RefreshService.CallRequestRefresh();
        }

        private async Task SwitchTheme() => await SetTheme(!isDark);
    }

    public record MarkdownPage(string PagePath, string PageName, NavLinkMatch NavLinkMatch, string SpanClass);
}
