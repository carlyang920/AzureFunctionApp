using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Sample.FunctionApp.Services;

[assembly: FunctionsStartup(typeof(Sample.FunctionApp.Startup))]
namespace Sample.FunctionApp
{
    public class Startup : FunctionsStartup
    {
        private IServiceProvider ServiceProvider { get; set; }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient<MyServices>();

            builder.Services.AddSingleton<MyServices>();

            ServiceProvider = builder.Services.BuildServiceProvider();
        }
    }
}
