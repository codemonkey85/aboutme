﻿using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace aboutme.Shared
{
    public static class JavaMethods
    {
        public static async Task DownloadFile(this IJSRuntime JSRuntime, string fileName, string mimeType, byte[] file) =>
            await JSRuntime.InvokeVoidAsync("BlazorDownloadFile", fileName, mimeType, file);

        public static async Task ChangeTheme(this IJSRuntime JSRuntime, bool isDark) =>
            await JSRuntime.InvokeVoidAsync("ChangeTheme", isDark);
    }
}
