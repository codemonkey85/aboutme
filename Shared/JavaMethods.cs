using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace aboutme.Shared
{
    public static class JavaMethods
    {
        public static async Task DownloadFile(this IJSRuntime JSRuntime, string fileName, string mimeType, byte[] file) =>
            await JSRuntime.InvokeVoidAsync("blazorDownloadFile", fileName, mimeType, file);

        public static async Task ChangeTheme(this IJSRuntime JSRuntime, bool isDark) =>
            await JSRuntime.InvokeVoidAsync("changeTheme", isDark);

        public static async Task AddToLocalStorage<T>(this IJSRuntime JSRuntime, string key, T value) =>
            await JSRuntime.InvokeVoidAsync("addToLocalStorage", key, value);

        public static async Task<string> ReadFromLocalStorage(this IJSRuntime JSRuntime, string key, string valueIfMissing = null) =>
            await JSRuntime.InvokeAsync<string>("readFromLocalStorage", key, valueIfMissing);
    }
}
