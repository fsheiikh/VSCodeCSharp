using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace HelloNancy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}

// ".UseContentRoot" tells the WebHost what folder to look for resources in. 
//We tell the WebHost what kind of server to connect to with ".UseKestrel"; 
//Kestrel is the cross-platform server we use for hosting our projects. 
//".UseStartup" ensures that our Startup.cs will be executed. 
//Finally, we Run the WebHost to establish the connection.