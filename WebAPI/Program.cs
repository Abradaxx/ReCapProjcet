using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Dependency_Resolvers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder=>
                {
                    builder.RegisterModule(new AutofacBusinessModule());
                    //olu?turdugumuz autofac i burada kulland?k.
                    /*Yar?n bi g?n autofac ten vazge?ersem Dependency Resolver e ekleme yapma
                     * ve program.cs de yani web apide newledi?imiz AutofacBusinessModule(); leri
                     * degistirelim.
                     */

                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
