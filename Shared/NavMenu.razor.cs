using Microsoft.AspNetCore.Components.Routing;

namespace aboutme.Shared
{
    public partial class NavMenu : ComponentBase
    {
        protected bool collapseNavMenu = true;

        protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected void ToggleNavMenu() => collapseNavMenu = !collapseNavMenu;

        protected MarkdownPage[] NavPages =
        {
            new (string.Empty, "Index", NavLinkMatch.All, "oi oi-home"),
            new ("resume", "Resume", NavLinkMatch.All, "oi oi-document"),
            new ("projects", "My Projects", NavLinkMatch.All, "oi oi-document"),
            new ("music", "Music I Like", NavLinkMatch.All, "oi oi-document"),
            new ("pokemon", "Pokémon", NavLinkMatch.All, "oi oi-document"),
            new ("contact", "Contact Me", NavLinkMatch.All, "oi oi-document"),
        };
    }

    public record MarkdownPage(string PagePath, string PageName, NavLinkMatch NavLinkMatch, string SpanClass);
}
