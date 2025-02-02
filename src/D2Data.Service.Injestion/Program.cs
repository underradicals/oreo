using D2.App.Kernel;
using D2Data.Service.Injestion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
var Configuration = builder.Configuration;

builder.Configuration.AddUserSecrets<Program>();


builder.Services.AddSettings<D2ResourceClientSettings>(Configuration, D2ResourceClientSettings.SectionName);
builder.Services.AddSingleton<ManifestSerializer>();
builder.Services.AddSingleton<ApplicationService>();

builder.Services.AddHttpClient(ProjectConstants.ManifestHttpClientName, client =>
{
    client.BaseAddress = new Uri("https://www.bungie.net");
    client.DefaultRequestHeaders.Add("x-api-key", Configuration["D2ResourceClientSettings:D2ApiKey"]);
});

var app = builder.Build();

var serviceProvider = app.Services;
var service = serviceProvider.GetService<ApplicationService>();
service?.Run();