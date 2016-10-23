using Microsoft.AspNetCore.Builder;
using Nancy.Owin;
using Microsoft.Extensions.Logging;

//we're using OWIN to connect Nancy's libraries to our project. 
//OWIN stands for "Open Web Interface for .NET", it allows us to 
//connect any amount of middleware to our request/response pipeline. 
//For our purposes, this means we can use it to give third party code
//(in this case Nancy) access to handle HTTP requests.


namespace HelloNancy
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory LoggerFactory)
        {   
            LoggerFactory.AddConsole();
            app.UseOwin(x => x.UseNancy());
            
           
        }
    }
}