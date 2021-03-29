using AutoMapper;
using BrustRecipes.Models;
using BrustRecipes.Models.Recipe;
using BrustRecipes.Repositories.Entities.Recipes;

namespace BrustRecipes.Configuration.Automapper
{
    public class RecipeConfiguration : Profile
    {
        /// <summary>
        /// Configures Recipe mappings
        /// </summary>
        public RecipeConfiguration()
        {
            //Recipe Entity to recipe domain
            CreateMap<RecipeEntity, Recipe>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.RecipeId))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.RecipeName))
                .ForMember(dest => dest.PreparationTime, opts => opts.MapFrom(src => src.RecipePrepTime))
                .ForMember(dest => dest.Difficulty, opts => opts.MapFrom(src => src.RecipeDifficulty))
                .ForMember(dest => dest.ServingSize, opts => opts.MapFrom(src => src.RecipeServingSize))
                .ForMember(dest => dest.Directions, opts => opts.MapFrom(src => src.RecipeDirections))
                .ForMember(dest => dest.Comments, opts => opts.MapFrom(src => src.RecipeComments))
                .ForMember(dest => dest.Source, opts => opts.MapFrom(src => src.RecipeSource))
                .ForMember(dest => dest.Base, opts => opts.MapFrom(src => src.RecipeBase.BaseDescription))
                .ForMember(dest => dest.Course, opts => opts.MapFrom(src => src.RecipeCourse.CourseDescription))
                .ForMember(dest => dest.Ethnicity, opts => opts.MapFrom(src => src.RecipeEthnicity.EthnicityDescription))
                .ForMember(dest => dest.PreparationTime, opts => opts.MapFrom(src => src.RecipePrepTime.PrepTimeDescription))
                .ForMember(dest => dest.Difficulty, opts => opts.MapFrom(src => src.RecipeDifficulty.DifficultyDescription))
                .ForMember(dest => dest.Ingredients, opts => opts.MapFrom(src => src.RecipeIngredients))
                .ReverseMap();

            //Recipe Domain to return model
            CreateMap<Recipe, RecipeReturnModel>()
                .ReverseMap();

            ////Course Entity to course domain
            //CreateMap<Course, CourseEntity>()
            //    .ForMember(d => d.CourseId, opts => opts.MapFrom(src => src.Id))
            //    .ForMember(d => d.CourseDescription, opts => opts.MapFrom(src => src.Description))
            //    .ReverseMap();

            ////Course Domain to return model
            //CreateMap<Course, CourseReturnModel>()
            //    .ReverseMap();

            ////Base Entity to base domain
            //CreateMap<Base, BaseEntity>()
            //    .ForMember(d => d.BaseId, opts => opts.MapFrom(src => src.Id))
            //    .ForMember(d => d.BaseDescription, opts => opts.MapFrom(src => src.Description))
            //    .ReverseMap();

            ////Base Domain to return model
            //CreateMap<Base, BaseReturnModel>()
            //    .ReverseMap();
        }
    }
}