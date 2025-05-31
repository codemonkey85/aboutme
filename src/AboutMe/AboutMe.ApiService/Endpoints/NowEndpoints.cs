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

    private static async Task<IResult> GetNowThings(AirTableClientSettings? airtableClientSettings)
    {
        if (airtableClientSettings is not
            {
                AppKey: { Length: > 0 } appKey,
                BaseId: { Length: > 0 } baseId
            })
        {
            return Results.InternalServerError("AirTable client settings improperly configured.");
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
}
