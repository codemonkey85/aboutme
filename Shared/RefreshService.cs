using System;

namespace aboutme.Shared
{
    public class RefreshService : IRefreshService
    {
        public event Action RefreshRequested;

        public void CallRequestRefresh() => RefreshRequested?.Invoke();
    }
}
