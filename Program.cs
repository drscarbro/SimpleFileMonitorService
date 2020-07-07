using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using SimpleFileMonitor.Services;
using SimpleFileMonitor.Services.Interfaces;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace SimpleFileMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseWindowsService()
            .ConfigureServices((hostContext, services) => 
                services.AddHostedService<FileMonitor>());
    }
}
