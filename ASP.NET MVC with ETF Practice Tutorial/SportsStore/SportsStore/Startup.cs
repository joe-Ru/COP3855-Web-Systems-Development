using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SportsStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //TODO: Look into why EnableEndpointRouting doesnt work.
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // This method displays details of exceptions that occur in the app
            app.UseDeveloperExceptionPage(); 
      
            //This extension method adds a simple message to the HTTP responses that otherwise would not be listed.
            app.UseStatusCodePages(); 

            //Extension method enables support for serving static content
            app.UseStaticFiles(); 

            // Extension method enables ASP.NET Core MVC with a default config.
            app.UseMvcWithDefaultRoute();

            //ConfigureServices method is used to set up shared objects that can be used throughout the application through the
            // dependency injection feature. AddMvc method sets up shared objects used in MVC apps.
            // Configure method is used to set up features that receive and process HTTP requests.
            //Each method we call in configure method is an extension method that sets up an HTTP request processor.
        }
    }
}
