var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMudServices();
await builder.Build().RunAsync();
