var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.D2_Data_DapperApi>("d2-data-dapperapi");
builder.AddProject<Projects.D2_Data_EFCoreApi>("d2-data-efcoreapi");
builder.AddProject<Projects.D2_Docs_RazorClient>("d2-data-razorclient");

builder.Build().Run();
