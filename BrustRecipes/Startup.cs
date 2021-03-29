using BrustRecipes.Configuation.Automapper;
using BrustRecipes.Configuration.Swagger;
using BrustRecipes.Repositories;
using BrustRecipes.Repositories.Abstractions;
using BrustRecipes.Services;
using BrustRecipes.Services.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrustRecipes
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

            // Register the Swagger generator, defining 1 or more Swagger documents
            //services.AddSwaggerGen();
            services.ConfigureSwagger();

            // Configure Automapper
            services.UseAutomapper();

            ConfigureDI(services);
            ConfigureRecipeServices(services);

        }

        private void ConfigureDI(IServiceCollection services)
        {
            services.AddScoped<IJetDataContext, JetDataContext>();
            services.AddDbContext<JetDataContext>(options =>
            {
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            });
        }

        /// <summary>
        /// Configures Recipe services
        /// </summary>
        /// <param name="services"></param>
        private void ConfigureRecipeServices(IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                //c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
