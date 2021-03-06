using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace BlazorWebassemblyStart
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            // Register Syncfusion license ver 19.2.0.47
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDcwNzIzQDMxMzkyZTMyMmUzMGJYNHlyK2tVQm9VRXlHRDlCaUdIRGxYSzFaZERLNUp1OFF5Y051L3Z2Ync9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
             
    }
}
