using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VMS_App.Client;
using MudBlazor.Services;
using VMS_App.Client.LoginService;
using VMS_App.Client.Service;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped<LoginService, LoginService>();
builder.Services.AddScoped<IHttpService, HttpService>(option=> new HttpService(new HttpClient() { BaseAddress= new Uri("https://110.227.194.109:6034/") }));

await builder.Build().RunAsync();
