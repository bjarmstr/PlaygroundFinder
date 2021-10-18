using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PlaygroundFinder.Repositories;
using PlaygroundFinder.Repositories.Repositories;
using PlaygroundFinder.Repositories.Repositories.Interfaces;
using PlaygroundFinder.Services;
using PlaygroundFinder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundFinder.API
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
            

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(  // Connect to the Postgres database
                    Configuration.GetConnectionString("DefaultConnection"),
                    builder => {
                        //project where we want Code-First Migrations to reside
                        builder.MigrationsAssembly("PlaygroundFinder.Repositories");
                        builder.UseNetTopologySuite();
                    })
                );

            services.AddScoped<IPlaygroundRepository, PlaygroundRepository>();
            services.AddScoped<IPlaygroundService, PlaygroundService>();
            services.AddScoped<IFeatureDetailService, FeatureDetailService>();
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MKTFY API", Version = "v1" });
                var apiPath = Path.Combine(System.AppContext.BaseDirectory, "PlaygroundFinder.Api.xml");
                var modelsPath = Path.Combine(System.AppContext.BaseDirectory, "PlaygroundFinder.Models.xml");
                c.IncludeXmlComments(apiPath);
                c.IncludeXmlComments(modelsPath);
                //c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                //{
                //    Type = SecuritySchemeType.Http,
                //    BearerFormat = "JWT",
                //    In = ParameterLocation.Header,
                //    Scheme = "bearer"
                //});
               // c.OperationFilter<AuthHeaderOperationFilter>();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlaygroundFinder.API v1"));
            }

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
