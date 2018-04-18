using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestaurantAPI.Services;

namespace RestaurantAPI
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddMvc();
        }
        // 
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
                              IHostingEnvironment env,
                              IConfiguration configuration,
                              IGreeter greeter,
                              ILogger<Startup> logger)
        {
            //app.UseDefaultFiles();
            //app.UseStaticFiles();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseStaticFiles();

            app.UseMvc(ConfigureRoutes);

            //app.UseMvcWithDefaultRoute();



            app.Run(async (context) =>
                 {
                 //   //throw new Exception("Error");
                
                 var greeting = greeter.GetMessageOfTheDay();
                     context.Response.ContentType = "text/plain";
                 await context.Response.WriteAsync($"{greeting} : {env.EnvironmentName}");
        });



        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}");
        }
    }
}