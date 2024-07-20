using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using MySpotify.Portal.Common.Configurations;
using MySpotify.Portal.DataServices.Spotify.Api;
using MySpotify.Portal.Web;
using MySpotify.Portal.Web.Themes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();


builder.Services.Configure<SpotifyOptions>(opts =>
{
    builder.Configuration.Bind("Spotify", opts);
});

builder.Services.AddTransient<ISpotifyTokenProvider, SpotifyTokenProvider>();
builder.Services.AddTransient<ISpotifyHttpServiceProvider, SpotifyHttpServiceProvider>();

builder.Services.AddSingleton(sp =>
{
    var spotifyOptions = new SpotifyOptions();
    builder.Configuration.Bind("Spotify", spotifyOptions);
    return spotifyOptions;
});

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
