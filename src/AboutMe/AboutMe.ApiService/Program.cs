using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
services.AddOpenApi();

if (!builder.Environment.IsDevelopment())
{
    var keyVaultName = Environment.GetEnvironmentVariable("AzureKeyVault__Vault");

    if (keyVaultName is not { Length: > 0 })
    {
        throw new InvalidOperationException(
            "Azure Key Vault name is not set in environment variables.");
    }

    if (!string.IsNullOrEmpty(keyVaultName))
    {
        var keyVaultUri = new Uri($"https://{keyVaultName}.vault.azure.net/");
        builder.Configuration.AddAzureKeyVault(keyVaultUri, new DefaultAzureCredential());
    }
}

var airtableClientSettings = builder.Configuration
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
