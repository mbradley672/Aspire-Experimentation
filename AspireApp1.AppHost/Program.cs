var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ApiGateway>("apigateway");

builder.AddProject<Projects.BasketService>("basketservice");

builder.Build().Run();
