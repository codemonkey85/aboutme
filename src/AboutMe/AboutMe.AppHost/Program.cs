using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder
    .AddProject<AboutMe_ApiService>("apiservice")
    .WithExternalHttpEndpoints();

builder
    .AddProject<AboutMe_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
