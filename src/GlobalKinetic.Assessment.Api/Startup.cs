using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalKinetic.Assessment.BusinessLayer.Implementation;
using GlobalKinetic.Assessment.BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace GlobalKinetic.Assessment.Api
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddSingleton<ICoinJar, CoinJar>();
      services.AddSwaggerGen(options =>
      {
        options.SwaggerDoc("v1.0.0", new Microsoft.OpenApi.Models.OpenApiInfo
        {
          Title = "Global Kinetic Assessment v1.0.0",
          Version = "v1.0.0",
          Description = "Global Kinetic Assessment v1.0.0",
          Contact = new OpenApiContact
          {
            Email = "luyolom@gmail.com",
            Name = "Luyolo Mgodi",

          } 
        });
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      
   
      app.UseSwagger(c =>
      {
        c.SerializeAsV2 = true;
      });
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("swagger/v1.0.0/swagger.json", "v1.0.0");
        c.RoutePrefix = string.Empty;
      });

      app.UseHttpsRedirection();
      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

    }
  }
}
