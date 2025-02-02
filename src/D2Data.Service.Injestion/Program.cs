using D2Data.Service.Injestion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

var builder = Host.CreateApplicationBuilder(args);
var Configuration = builder.Configuration;

builder.Configuration.AddUserSecrets<Program>();

builder.Services.Configure<D2ResourceClientSettings>(Configuration.GetSection(D2ResourceClientSettings.SectionName));
builder.Services.AddSingleton(service => service.GetRequiredService<IOptions<D2ResourceClientSettings>>().Value);
builder.Services.AddHttpClient("D2ResourceClient", client =>
{
    client.BaseAddress = new Uri("https://www.bungie.net");
    client.DefaultRequestHeaders.Add("x-api-key", Configuration["D2ResourceClientSettings:D2ApiKey"]);
});

var app = builder.Build();