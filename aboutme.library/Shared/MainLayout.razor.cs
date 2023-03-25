namespace aboutme.library.Shared;

public partial class MainLayout
{
    protected bool _drawerOpen = true;

    protected void DrawerToggle() => _drawerOpen = !_drawerOpen;
}
