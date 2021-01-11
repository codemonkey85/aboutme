using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace aboutme.Shared
{
    public partial class NavMenu : ComponentBase
    {
        protected bool collapseNavMenu = true;

        protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected void ToggleNavMenu() => collapseNavMenu = !collapseNavMenu;

        protected MarkdownPage[] Pages =
        {
            new MarkdownPage("", "Index", NavLinkMatch.All, "oi oi-home"),
            new MarkdownPage("resume", "Resume", NavLinkMatch.All, "oi oi-document"),
            new MarkdownPage("music", "Music I Like", NavLinkMatch.All, "oi oi-document"),
            new MarkdownPage("pokemon", "Pokémon", NavLinkMatch.All, "oi oi-document"),
        };
    }

    public record MarkdownPage(string PagePath, string PageName, NavLinkMatch NavLinkMatch, string SpanClass);
}
