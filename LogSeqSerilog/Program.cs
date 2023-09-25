using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;

var builder = WebApplication.CreateBuilder(args);



var logger = new LoggerConfiguration()
    .WriteTo.Seq("http://localhost:5341", apiKey: "0Bhs3mPNlcG1HEz6FAG4")
    .Enrich.FromLogContext()
    .Enrich.WithEnvironmentName()
    .Enrich.WithMachineName()
    .CreateLogger();
builder.Host.UseSerilog(logger); //assim captura todos os ILogger

Log.Information("Starting up");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();







// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSerilogRequestLogging();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
