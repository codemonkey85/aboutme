var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AboutMe_ApiService>("apiservice");

builder.AddProject<Projects.AboutMe_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
