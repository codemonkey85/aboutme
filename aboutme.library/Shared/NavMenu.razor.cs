namespace aboutme.library.Shared;

public partial class NavMenu
{
    protected bool CollapseNavMenu = true;

    protected string? NavMenuCssClass => CollapseNavMenu ? "collapse" : null;

    protected void ToggleNavMenu() => CollapseNavMenu = !CollapseNavMenu;
}
