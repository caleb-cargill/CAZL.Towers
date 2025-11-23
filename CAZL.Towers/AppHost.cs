var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CAZL_Towers_API>("cazl-towers-api");

builder.Build().Run();
