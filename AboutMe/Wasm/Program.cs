var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;

services
    .AddMudServices()
    .AddScoped(_ => new HttpClient { BaseAddress = new(builder.HostEnvironment.BaseAddress) });

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();
