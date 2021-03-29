using AutoMapper;
using BrustRecipes.Models;
using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Entities.Recipes;

namespace BrustRecipes.Configuration.Automapper
{
    public class IngredientConfiguration : Profile
    {
        /// <summary>
        /// Configures Recipe mappings
        /// </summary>
        public IngredientConfiguration()
        {
            //Ingredient Entity to return model
            CreateMap<IngredientEntity, IngredientReturnModel>()
                .ForMember(d => d.Name, opts => opts.MapFrom(src => src.IngredientName))
                .ReverseMap();
        }
    }
}