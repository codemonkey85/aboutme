namespace aboutme.Shared
{
    public interface IRefreshService
    {
        event Action RefreshRequested;

        void CallRequestRefresh();
    }
}
