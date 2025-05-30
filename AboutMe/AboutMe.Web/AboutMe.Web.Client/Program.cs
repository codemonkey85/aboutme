using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;

services
    .AddMudServices();

await builder.Build().RunAsync();
