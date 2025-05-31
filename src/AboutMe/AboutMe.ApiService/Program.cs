using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
services.AddOpenApi();

var config = builder.Configuration;

if (!builder.Environment.IsDevelopment())
{
    var keyVaultName = config["AzureKeyVault:Vault"];
    if (!string.IsNullOrEmpty(keyVaultName))
    {
        var keyVaultUri = new Uri($"https://{keyVaultName}.vault.azure.net/");
        config.AddAzureKeyVault(keyVaultUri, new DefaultAzureCredential());
    }
}

var airtableClientSettings = config
    .GetSection(nameof(AirTableClientSettings))
    .Get<AirTableClientSettings>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app
    .MapNowEndpoints(airtableClientSettings)
    .MapBlogEndpoints();

app.MapDefaultEndpoints();

app.Run();
