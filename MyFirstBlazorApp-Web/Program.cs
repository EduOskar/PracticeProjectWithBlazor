using eShop.DataStore.HardCoded_Infrastructure_;
using eShop.UseCases_Application_.PluginInterfaces.DataStore;
using eShop.UseCases_Application_.SearchProductScreen;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MyFirstBlazorApp_Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ISearchProduct, SearchPoduct>();
builder.Services.AddTransient<IViewProduct, ViewProduct>();   

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
