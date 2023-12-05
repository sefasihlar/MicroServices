using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot();



//�stenilen i�lemle g�re y�nlendirme istegi

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    var env = hostingContext.HostingEnvironment;
    config
        .AddJsonFile($"configuration.{env.EnvironmentName.ToLower()}.json", optional: true, reloadOnChange: true)
        .AddEnvironmentVariables();
});

var app = builder.Build();

app.UseRouting();

// Ocelot pipeline'�n� ekleyin
app.UseOcelot().Wait();

app.Run();
