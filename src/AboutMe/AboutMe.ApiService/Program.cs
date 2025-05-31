var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

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
