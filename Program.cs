using aboutme;
using aboutme.Shared;
using MarkdownSharp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new Markdown(new MarkdownOptions { }));
builder.Services.AddScoped<JsInterop>();
builder.Services.AddScoped<IRefreshService, RefreshService>();

await builder.Build().RunAsync();
