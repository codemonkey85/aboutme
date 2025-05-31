namespace AboutMe.ApiService.Endpoints;

public static class NowEndpoints
{
    public static IEndpointRouteBuilder MapNowEndpoints(
        this IEndpointRouteBuilder app,
        AirTableClientSettings? airtableClientSettings)
    {
        app.MapGet("/now", async () => await GetNowThings(airtableClientSettings));

        return app;
    }

    private static async Task<IResult> GetNowThings(AirTableClientSettings? appSettings)
    {
        if (appSettings is not { AppKey: { } appKey, BaseId: { } baseId })
        {
            return Results.InternalServerError();
        }

        using var airtableBase = new AirtableBase(appKey, baseId);
        var response = await airtableBase.ListRecords("NowThings");

        if (response.Success)
        {
            List<NowThing> nowThings = [];
            foreach (var record in response.Records)
            {
                nowThings.Add(new NowThing
                {
                    Title = record.GetField<string>("Title") ?? string.Empty,
                    Description = record.GetField<string>("Description") ?? string.Empty,
                    Url = record.GetField<string>("URL")
                });
            }

            return Results.Ok(nowThings);
        }

        return Results.Problem(response.AirtableApiError.Message ?? "Failed to load now things.");
    }

    internal record NowThing
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string? Url { get; set; }
    }
}
