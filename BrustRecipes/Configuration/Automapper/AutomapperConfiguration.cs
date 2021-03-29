using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Linq;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;

namespace BrustRecipes.Configuation.Automapper
{
    /// <summary>
    /// Service configuration for automapper
    /// </summary>
    public static class AutomapperConfiguration
    {
        /// <summary>
        /// Configures the app to use automapper
        /// </summary>
        /// <param name="services"></param>
        public static void UseAutomapper(this IServiceCollection services)
        {
            var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(Profile).IsAssignableFrom(t)).ToList();
            // Auto Mappr Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddExpressionMapping();
                profiles.ForEach(x => mc.AddProfile(x));
            });
            services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}
