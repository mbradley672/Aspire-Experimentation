var builder = DistributedApplication.CreateBuilder(args);

var catalogDb = builder.AddPostgresContainer("catalog")
    .AddDatabase("catalogdb");
var basketCache = builder.AddRedisContainer("basket-cache");



builder.AddProject<Projects.ApiGateway>("apigateway");

builder.AddProject<Projects.BasketService>("basketservice");

builder.AddProject<Projects.CatalogDb>("catalogdb");

builder.Build().Run();
