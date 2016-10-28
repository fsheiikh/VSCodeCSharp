using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace YourNamespace
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder App)
        {   
            //App.UseStaticFiles(); //not working, so i put styling in html

            // App.UseMvc( routes =>
            // {
            //     routes.MapRoute(
            //         name: "Default", // The route's name is only for our own reference
            //         template: "", // The pattern that the route matches
            //         defaults: new {controller = "Hello", action = "Index"} // The controller and method to execute
            //     );
            // });

             App.UseMvc();
             App.UseSession();
        }
    }


}