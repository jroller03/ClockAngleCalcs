using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace ClockAngle
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });
      app.UseStaticFiles();
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("404 Not Found"); //default -- checks to see if working before adding content
      });
    }
  }
}
