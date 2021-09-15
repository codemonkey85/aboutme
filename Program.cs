using aboutme.Shared;
using MarkdownSharp;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace aboutme
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new Markdown(new MarkdownOptions { }));
            builder.Services.AddScoped<JsInterop>();
            builder.Services.AddScoped<IRefreshService, RefreshService>();

            await builder.Build().RunAsync();
        }
    }
}
