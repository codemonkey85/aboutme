using Microsoft.JSInterop;

namespace aboutme.Shared
{
    public class JsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        #region Constructor / Destructor

        public JsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", $"./_content/js/js-helper.js").AsTask());
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                IJSObjectReference module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }

        #endregion

        #region Private methods

        private async Task<T> InvokeAsync<T>(string method, params object[] args)
        {
            IJSObjectReference module = await moduleTask.Value;
            return await module.InvokeAsync<T>(method, args);
        }

        private async Task InvokeVoidAsync(string method, params object[] args)
        {
            IJSObjectReference module = await moduleTask.Value;
            await module.InvokeVoidAsync(method, args);
        }

        #endregion

        public async Task DownloadFile(string fileName, string mimeType, byte[] file) =>
            await InvokeVoidAsync("blazorDownloadFile", fileName, mimeType, file);

        public async Task ChangeTheme(bool isDark) =>
            await InvokeVoidAsync("changeTheme", isDark);

        public async Task AddToLocalStorage<T>(string key, T value) =>
            await InvokeVoidAsync("addToLocalStorage", key, value);

        public async Task<string> ReadFromLocalStorage(string key, string valueIfMissing = null) =>
            await InvokeAsync<string>("readFromLocalStorage", key, valueIfMissing);
    }
}
