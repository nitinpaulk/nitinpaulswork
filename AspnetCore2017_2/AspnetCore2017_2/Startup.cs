using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AspnetCore2017_2
{
    public class Startup
    {
        private IConfiguration _configService; 
        public Startup(IConfiguration configService)
        {
            this._configService = configService;

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                //DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions();
                //developerExceptionPageOptions.SourceCodeLineCount = 10;
                app.UseDeveloperExceptionPage();
            }

            DefaultFilesOptions files = new DefaultFilesOptions();
            files.DefaultFileNames.Clear();
            files.DefaultFileNames.Add("Foo.html");
            app.UseDefaultFiles(files);
            app.UseStaticFiles();

            FileServerOptions fileServerOptions = new FileServerOptions();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("Foo.html");
            app.UseFileServer();

            app.Use(async (context, next) =>
            {
                string text = $"Hello World! This process is being run by: " +
                              System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                string newKey = _configService["MyKey"];
                await context.Response.WriteAsync(text);
                await next();
            });

            app.Run(async (context) =>
            {
                throw new Exception("Invalid Page");
                string text = $"Hello World! This process is being run by: " +
                              System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                string newKey = _configService["MyKey"];
                await context.Response.WriteAsync(text);
            });
        }
    }
}
