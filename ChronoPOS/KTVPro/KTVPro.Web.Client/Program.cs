using KTVPro.Shared.Services;
using KTVPro.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the KTVPro.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddScoped<GlobalVariables>();
builder.Services.AddScoped<CommonFunctions>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<NotifierService>();
builder.Services.AddScoped<LanguageService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
